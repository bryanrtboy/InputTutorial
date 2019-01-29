# InputTutorial
Currently, this is just an empty project. There will be a video tutorial posted, and then I will post this project as a stub for you to complete based on the video.

Concept: The user places a target on the ground and then they use their voice to start a frog or other object to move to the target. For now, we will just use volume to trigger the motion, but an obvious extension would be to use voice recognition and a word like 'Go'.

## Step 1: Psuedo code

#### Place target script:

* On mouse down

 * target appears
 * target is placed on the ground
 * target follows the mouse pointer

* On mouse up
 * target is placed
 * frog knows where the target is, but does not move yet

#### Move to target script (placed on the frog)

* Microphone is turned on
* Microphone audio is checked for volume
* If volume is over X, frog starts moving


