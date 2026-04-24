# Maze_labrynth
Uni project WBL
Important Note About This Build

The included build zip is an older playable version of the game that was previously used for external playtesting. It does not include the final art/assets, as those were integrated very late in development. At present, this is the only stable version of the game that is able to run correctly.

Unfortunately, the newer WebGL build with the final assets is currently encountering runtime errors beyond my present technical understanding and capability to resolve before submission. I received the final assets only the day before the hand-in date, which left very limited time to integrate, test, diagnose, and solve these issues.
Current WebGL Runtime Error Encountered

The primary error being produced is:
RuntimeError: call_indirect to a signature that does not match
(evaluating 'dynCall_iiii(index,a1,a2,a3)')
Additional console output includes:
invoke_iiii @ MazeFin.framework.js.gz
Browser_mainLoop_runner
runIter
callUserCallback
wasm-function[35481]
wasm-function[37173]
wasm-function[38600]
wasm-function[55103]

This appears tied to a Unity WebGL runtime/signature issue during browser execution. I have attempted troubleshooting through rebuilds, deployment changes, and control/input revisions, but was unable to resolve it in time.
How to run game locally on web

Once the project loads in the Unity Editor, select File > Build Profiles from the main menu. Under the Platforms section, make sure the Web is selected. Wait until the process finishes.

Note: If you have previously downloaded Unity 6 without the WebGL Build Support module, a dialogue will appear informing you that you need to download it in order to proceed. Follow the instructions to download it before you proceed with the rest of the tutorial.

The game build consists of multiple different test scenes. For your purposes, you don’t need all of them, so make a build that contains only the MazeScene.

Once the build target has switched to Web, select the Open Scene List button in the right panel and disable all the scenes except for the MazeScene.

Select Web from the Platforms section again and select Build And Run

Note: If you’re unable to directly select the Web platform again, select another platform and then select the Web platform.
You’ll be prompted to select a folder where you’ll place the build. 
Create a new folder in the WebGL project folder and name it “www_maze”.
Unity will now build that scene for the web. This can take several minutes.
Once the scene has been built, the Unity Editor will start a local web-server and open your default browser to load the build web page.
The local web-server is limited to the computer you created the project on; other computers on the network won't be able to view the web page.
You can select the blue fullscreen button in the lower-right corner to expand the game to be in fullscreen mode.

For Kinetic Arts Lab Team
I sincerely apologize that the most up-to-date asset-complete version could not be submitted in a working state. This was not for lack of effort; rather I reached technical issues I was unable to confidently solve before the deadline.
The included build represents the latest stable playable version available and demonstrates the implemented gameplay systems for testing and assessment.
Thank you for your understanding.

