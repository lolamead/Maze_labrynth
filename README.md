# Maze_labrynth
Uni project WBL
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
