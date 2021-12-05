using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SimpleShapes.Shapes;

namespace SimpleShapes
{
    public enum BasicShape 
    {
        square = 1,
        circle = 2,
        triangle = 3,
        hexagon = 4
    }
    public enum Movement
    {
        horizontal = 1,
        vertical = 2,
        box = 3,
        circular = 4
    }
    public partial class Form1 : Form
    {
        #region Variables and Parameters
        Graphics graphics;
        Pen pen;
        Shape shape;
        Movement move;
        BasicShape basicShape;

        Dictionary<string, Color> colors = new Dictionary<string, Color>()
        {
            {"black", Color.Black},
            {"red", Color.Red},
            {"blue", Color.Blue},
            {"yellow", Color.Yellow},
            {"green", Color.Green},
            {"orange", Color.Orange}
        };

        int borderRight;
        int borderLeft = 0;
        int borderTop = 0;
        int borderBottom;

        int radius = 5;
        int startCenteredX;
        int startCenteredY;

        int edge;
        Color color = Color.LightGreen;

        string fileName;
        string fileText;
        string[] userTextArr = new string[4];

        bool isDimensionValid;
        #endregion

        public Form1()
        {
            InitializeComponent();
            graphics = PictureBox.CreateGraphics();
            borderRight = PictureBox.Width;
            borderBottom = PictureBox.Height;
            startCenteredX = PictureBox.Width / 2;
            startCenteredY = PictureBox.Height / 2;
            ColorPBox.BackColor = color;
        }

        //Initializes a shape and draws it
        private void DrawAShape(BasicShape basicShape)
        {
            pen = new Pen(color, 5);
            graphics.Clear(Color.White);

            switch (basicShape)
            {
                case BasicShape.circle:
                    shape = new Circle(startCenteredX, startCenteredY, edge);
                    break;
                case BasicShape.square:
                    shape = new Square(startCenteredX, startCenteredY, edge);
                    break;
                case BasicShape.triangle:
                    shape = new Triangle(startCenteredX, startCenteredY, edge);
                    break;
                case BasicShape.hexagon:
                    shape = new Hexagon(startCenteredX, startCenteredY, edge);
                    break;
            }

            shape.Draw(graphics, pen);
        }

        //Stores a value in basicShape enum according to clicked radio batton (chosen shape), calls a message box if 
        //requirements for a shape creation do not match/are missed; calls a method for shape drawing
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (TriangleRadBtn.Checked)
                basicShape = BasicShape.triangle;

            if (SquareRadBtn.Checked)
                basicShape = BasicShape.square;

            if (CircleRadBtn.Checked)
                basicShape = BasicShape.circle;

            if (HexagonRadBtn.Checked)
                basicShape = BasicShape.hexagon;

            if (edge == 0 || basicShape == 0)
                MessageBox.Show("You sure you've chosen a shape or puted a dimension? Check again");
            else
                DrawAShape(basicShape);
        }

        #region Movement Buttons
        //Each method validates (checks in a separate method) if shape variable has a value (is created) to make it move.
        //If not - validation method will call a message box
        private void MoveYBtn_Click(object sender, EventArgs e)
        {
            if (!CheckIfShapeIsNull(shape))
            {
                timer1.Start();
                move = Movement.vertical;
            }
        }
        private void MoveXBtn_Click(object sender, EventArgs e)
        {
            if (!CheckIfShapeIsNull(shape))
            {
                timer1.Start();
                move = Movement.horizontal;
            }
        }
        private void MoveBoxClockWiseBtn_Click(object sender, EventArgs e)
        {
            if (!CheckIfShapeIsNull(shape))
            {
                timer1.Start();
                move = Movement.box;
            }
        }
        private void MoveCircleClockwiseBtn_Click(object sender, EventArgs e)
        {
            if (!CheckIfShapeIsNull(shape))
            {
                timer1.Start();
                move = Movement.circular;
            }
        }
        #endregion

        #region Timer related stuff
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            if(move == 0)
                MessageBox.Show("You should create a shape to make it move. That's how it works");
            else
            {
                switch (move)
                {
                    case Movement.horizontal:
                        shape.MoveHorizontaly(graphics, pen, borderRight, borderLeft);
                        break;
                    case Movement.vertical:
                        shape.MoveVerticaly(graphics, pen, borderTop, borderBottom);
                        break;
                    case Movement.box:
                        shape.MoveBoxClockwise(graphics, pen,
                                borderRight - 50, borderBottom - 50, borderLeft + 50, borderTop + 50); //I've added/subtracted 50 from each border                              
                        break;                                                                   //to create "margins" so a shape would move on some
                    case Movement.circular:                                                     // distance from borders instead of sliding on them
                        shape.MoveCircleClockwise(graphics, pen, radius);
                        break;
                }
            }
        }

        private void FasterMoveRateBtn_Click(object sender, EventArgs e)
        {
            if (timer1.Interval == 50)                          //Timer interval can't be 0, so the minimal time interval will always be 50
                timer1.Interval = timer1.Interval;
            else
                timer1.Interval -= 50;
        }

        private void SlowerMoveRateBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval += 25;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        #endregion


        #region User Input Validation
        //Checks if shape variable is null. If yes - calls a message box
        private bool CheckIfShapeIsNull(Shape shape)
        {
            if (shape == null)
            {
                MessageBox.Show("You should create a shape to make it move. That's how it works, weirdo");
                return true;
            }
            return false;
        }

        //checks if dimension(shape side/diameter) is 0. Calls message box if yes
        private void DimensionsTxtBox_Validating(object sender, CancelEventArgs e)
        {
            DimensionValidation(DimensionsTxtBox.Text);
            if(!isDimensionValid || DimensionsTxtBox.TextLength == 0)
            {
                e.Cancel = true;
                DimensionsTxtBox.Focus();
                MessageBox.Show("You must give a numeric value: > 0 and <= 150 px");
                errorProvider1.SetError(DimensionsTxtBox, "You must give a numeric value: > 0 and <= 150 px");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DimensionsTxtBox, "");
            }
        }

        //Checks if dimension is numeric, and it matches requieremnts (equal/lesser than 150, greater than 0)
        private void DimensionValidation(string value)
        {
            int result = 0;
            if (int.TryParse(value, out result))
            {
                if (result > 150 || result < 1)
                    isDimensionValid = false;
                else
                {
                    edge = result;
                    isDimensionValid = true;
                }
            }
            else
                isDimensionValid = false;
        }

        //Calls Color Dialog window for user to chose a color 
        private void ColorPBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                ColorPBox.BackColor = color;
            }
        }

        //Opens FileExplorer window for user to chose a text file. Saves text file into variable
        private void ChoseFileTxtBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Chose txt file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                fileText = File.ReadAllText(fileName);
                ChoseFileTxtBox.Text = fileName;
            }
        }

        //Checks if file has required extension, pops up a message box if not. Calls a method for text file validation
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            string fileExtension = Path.GetExtension(fileName);

            if (fileExtension != ".txt")
                errorProvider1.SetError(ChoseFileTxtBox, "File extension must be .txt");

            TxtFileValidation();
        }

        //Do as it's name says - validates a text file
        private void TxtFileValidation()
        {
            //transform all letters to lower case and divide a string of text "into an array" 
            userTextArr = fileText.ToLower().Split(' ');

            //checking length of the string
            if(userTextArr.Length < 4)
            {
                MessageBox.Show("It seems you've missed some parameter (shape, color, dimension, move). " +
                    "Should be 4 parameters");
            }

            //check if any parameters contain digits (except size/dimension) or error will pop up
            for (int i = 0; i < userTextArr.Length; i++)
            {
                if (i == 1)
                    continue;
                else
                {
                    if (userTextArr[i].Any(char.IsDigit))
                    {
                        MessageBox.Show("There are digits on places of shape, movement, or color. " +
                            "Right pattern for this program is: " +
                            "'shape px color movement'. Use another file");
                        break;
                    }
                }
            }

            //shape validation
            if (!Enum.TryParse(userTextArr[0], out basicShape))
            {
                MessageBox.Show("You must specify one of 4 shapes (square, circle, triangle, hexagon) in your file, not some" +
                    "weird stuff");
            }

            //dimmension validation
            DimensionValidation(userTextArr[1]);
            if (!isDimensionValid)
            {
                MessageBox.Show("Size of side in your file violates requirements. Value must be numeric, lesser than 150, " +
                    "greater than 0");
            }

            //color validation
            foreach (KeyValuePair<string, Color> colorInput in colors)
            {
                if (userTextArr[2] == colorInput.Key)
                {
                    color = colorInput.Value;
                    ColorPBox.BackColor = color;
                    break;
                }
            }

            if(color == null)
                MessageBox.Show("Your color doesn't match requirements, chose another");

            //movement validation
            if (!Enum.TryParse(userTextArr[3], out move))
                MessageBox.Show("You must specify one of 4 movements: horizontal, vertical, circular, box");
        }

        //Separate button for creating a shape from txt file. I thought to make just one button for default creating a shape and creating from
        //file, but thought I had to reorganize UI, so decided to leave it as is
        private void CreateFromFileBtn_Click(object sender, EventArgs e)
        {
            DrawAShape(basicShape);
            timer1.Start();
        }
        #endregion
    }
}
