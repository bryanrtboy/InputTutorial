# InputTutorial
Currently, this is just an empty project. There will be a video tutorial posted, and then I will post this project as a stub for you to complete based on the video.
## Principles that you will learn
By following along in this tutorial you will learn:
* A workflow for starting a new project idea
* How to use 'psuedo-code'
* A standard set up for a game, including:
   * a Game Manager object (in this case following a Singleton pattern)
   * Organizing scripts for a single function, i.e. 'listen', 'place' or 'move'
* How to work with various forms of input
* Using ray casting and converting screenspace (mouse coordinates) to worldspace (where the frog lives)
* Introduction to the Navigation system

## Concept

The user places a target on the ground and then they use their voice to start a frog or other object to move to the target. For now, we will just use volume to trigger the motion, but an obvious extension would be to use voice recognition and a word like 'Go'.

## Step 1: Psuedo code
First we need to write out, to the best of our knowledge, what needs to happen and get an idea of how many scripts to write. Based on the concept, here is what I think we'll need:

#### Script: Place target:
* On mouse down
   * target appears
   * target is placed on the ground below the mouse pointer
   * target follows as the mouse pointer moves

* On mouse up
   * target is placed and becomes a valid target
   * frog knows where the target is, but does not move yet

#### Script: audio input trigger script
* Microphone is turned on
* Microphone audio is checked for volume
* If volume is over X, frog is told to move
* For testing, let's make keyboard commands to do stuff
    * 'g' to make the frog Go
    * 'r' to turn on the microphone

#### Script: Move to the target (placed on the frog)
* Frog waits to be told to move
* Using the Navigation system, move to the target on command

#### Script: Joystick input (placed on a Navigation Obstacle)
* Object needs to be an obstacle (using the Navigation system here)
* Joystick axis left/right moves obstacle left or right on the world X axis
* Joystick up/down moves obstacle on the world Z axis

## Step 2: Create scripts as stubs
At this point, simply create and name the scripts, putting a brief comment at the top for what this script is going to do. I've already noticed that several of these scripts need to 'talk' to each other, the frog needs to know the target was placed and where it is. The audio script needs to tell the frog to move. I'm starting to think that one of these scripts needs to be a Game Manager, letting everyone else know what's going on. We'll probably place that on an object that we call GameManager in the scene view as well. 

The others will just be placed on the object that needs to know, i.e. the frog or obstacle.

Some rules of thumb when naming:

* Name the scripts a name that says what it is supposed to do. Don't abbreviate! That's so 80's. Modern practices use longer, more descriptive script names that 'self-document' themselves
* Don't use common names, like 'Transform'. That's a reserved name, used by Unity and will cause your program to crash. Some people use their initials as a prefix, i.e. 'BLTransform' is fine.

## Step 3: Create functions in each script
Using your pseudocode as a start, create a new function in each script or use an existing Unity function when you can. We'll start with the Place target Script:

It turns out, there are several [MonoBehaviors](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) built into Unity that can help. MonoBehaviour is the base class from which every Unity script derives.

The MonoBehaviors **Start()** and **Update()** are automatically created when you create a new script. Looking at the [MonoBehavior Documentation](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) I found:

* **OnMouseDown**	OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
* **OnMouseDrag**	OnMouseDrag is called when the user has clicked on a GUIElement or Collider and is still holding down the mouse.
* **OnMouseEnter**	Called when the mouse enters the GUIElement or Collider.
* **OnMouseExit**	Called when the mouse is not any longer over the GUIElement or Collider.
* **OnMouseOver**	Called every frame while the mouse is over the GUIElement or Collider.
* **OnMouseUp**	OnMouseUp is called when the user has released the mouse button.

I think the **OnMouseOver()** function looks very promising for placing our target. I also notice that it requires a GUI or Collider. Colliders are on game objects in the 3D world, so I'll note that we probably need to put a collider on our ground.

Related searches in the documentation also showed we can check for a [mouse down input event](https://docs.unity3d.com/ScriptReference/Input.html):

* **GetMouseButton**	Returns whether the given mouse button is held down.
* **GetMouseButtonDown**	Returns true during the frame the user pressed the given mouse button.
* **GetMouseButtonUp**	Returns true during the frame the user releases the given mouse button.

Unlike **OnMouseOver()**, these do not require colliders and work a bit differently. For example, **GetMouseButtonDown** can be triggered at any time, regardless of whether the mouse is over anything. In order to check if the mouse is down, we need to put **GetMouseButtonDown** inside of the Update loop. This code snippet shows the difference:

```csharp
void OnMouseOver() {
//Do something if the mouse is over the collider attached to this game object
}
```
```csharp
// Update is called once per frame
void Update(){
        if (Input.GetMouseButtonDown(0)){
          //If the primary mouse button is pressed down, do something here
        }         
}
```

This Git project will go ahead and create these basic script stubs and organize the initial scene for you. Follow the video tutorial to write the actual code to make things work.

## Step 4 : Watch the video and write the scripts
In the video, I will describe what I am doing as I write out the actual functions.
