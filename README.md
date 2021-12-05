<h1>ShapeShifter</h1>
<i>Because it can... shift a shape... *ba dum tss*</i></br>
<a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/fbFBqqSY/ba-dum-tss.png' border='0' alt='ba-dum-tss'/></a></br>


Version 0.0.1 </br>
<b>Tested on:</b> Windows 10</br>
<b>Licence & Contributors:</b> Stacey Radushinskaya (varracosta) (@ starwisperer@gmail.com)</br>

A simple program for creating and moving 4 basic shapes of any (almost) color and any (almost  as well) size. 
It is also able to read and load parameters from a txt file, and create a moving shape. 

<h2> Detailed Description </h2>

A program can create one of 4 basic shapes: 
- square 
- circle 
- triangle (equilateral)
- hexagon 

User is also free to chose:
- dimension (length of side/edge for square, triangle, hexagon, and diameter for circle)
- color of shape outline (if none was chosen, color will be lime-green by default)

All shapes support 4 movement patterns: horizontal, vertical, circular and box-like clockwise. User can control the speed of a movement
by clicking on + or - buttons, or stop moving a shape with STOP button.


Program can validate your input, and check if you've left necessary for creating a shape fields (shapes radio buttons and dimension field) empty. 
It will prevent you from creating an emptyness, and yell at you with message boxes informing that you forgot something, or have put wrong dimensions. 



<h2> Uploading txt files in program </h2>

The program supports uploading parameters from a text file, and then creating a movable shape from it. It is also available to validate your text file if it mathes 
the requirements (see below). If not - you'll recieve a message box that something is wrong. 

<h3> Requirements for txt file: </h3>
Text file must be of .txt extension, and have 4 parameters separated by whitespace in a correct order:

`shape length_of_edge color movement `

E.g.: 

`circle 50 red horizontal`

<h3>Important notes</h3>

1) Program supports only these 4 shapes: circle, square, triangle, hexagon;
2) Dimension (length of shape side/diameter) is given in pixels, and must be from 1 to 150;
3) Colors available are: 
	- black
	- red
	- orange
	- green
	- blue
	- yellow
4) Movements: horizontal, vertical, circular, box; 
(P.S. Yep, last one is just "box" since I don't know how to call this movement pattern correctly)




<h2>HOW TO WORK WITH THE PROGRAM:</h2> 

So far the program works only on Windows 10 platform.

<h3>Creating a shape:</h3>
1) Load .exe
2) Chose one of 4 shapes by clicking according radio button
3) Enter length of side/diameter (px) or drag the value to "Edge/diameter" field
	Note: size should be between 0 - 150 
4) You can chose a color by clicking on a little square near "Color" label. If you won't chose any, the color will be lime-green by default
5) Click on "Create" button

(P.S. Only 1 shape can be created on canvas. An old shape will be deleted if you'll chose to create a new one)

<h3>Moving a shape:</h3>
1) Chose any of 4 movements by clicking on according button
2) Click on "+" button to increase the movement rate, and "-" to decrease it. Click "STOP" if you want the shape to... stop


<h3>Loading from a txt file</h3>
1) Create a txt file according to the requrements said above in README
2) Click the "Chose file" field under "Upload txt file" label - FileExplorer will open for you to chose your file. 
Or you can drag and drop the file into the said field
3) Click "Load"
4) If no angry Error Message boxes poped up, then you are all clear to create a shape by clicking "Create" button near "Load" btn








