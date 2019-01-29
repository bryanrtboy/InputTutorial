# InputTutorial
Currently, this is just an empty project. There will be a video tutorial posted, and then I will post this project as a stub for you to complete based on the video.

Concept: The user places a target on the ground and then they use their voice to start a frog or other object to move to the target. For now, we will just use volume to trigger the motion, but an obvious extension would be to use voice recognition and a word like 'Go'.

## Step 1: Psuedo code

First we need to write out, to the best of our knowledge, what needs to happen and get an idea of how many scripts to write. Based on the concept, here is what I think we'll need:

#### Place target script:

* On mouse down
   * target appears
   * target is placed on the ground
   * target follows the mouse pointer

* On mouse up
   * target is placed
   * frog knows where the target is, but does not move yet

#### Trigger Movement by audio input script

* Microphone is turned on
* Microphone audio is checked for volume
* If volume is over X, frog is told to move

#### Move to the target (placed on the frog)

* Frog waits to be told to move
* Using the Navigation system, move to the target on command

#### Move using Joystick input (placed on a Navigation Obstacle)

* Object needs to be an obstacle (using the Navigation system here)
* Joystick axis left/right moves obstacle left or right on the world X axis
* Joystick up/down moves obstacle on the world Z axis

## Step 2: Create scripts as stubs

At this point, simply create and name the scripts, putting a brief comment at the top for what this script is going to do. Some rules of thumb:

* Name the scripts a name that says what it is supposed to do. Don't abbreviate! That's so 80's. Modern practices use longer, more descriptive script names that 'self-document' themselves
* Don't use common names, like 'Transform'. That's a reserved name, used by Unity and will cause your program to crash. Some people use their initials as a prefix, i.e. 'BLTransform' is fine.

## Step 3: Create functions in each script

Using your pseudocode as a start, create a new function in each script or use an existing Unity function when you can. We'll start with the Place target Script:


