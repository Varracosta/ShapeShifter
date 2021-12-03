using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleShapes.Shapes;

namespace SimpleShapes
{
    public enum Movement
    {
        Horizontal,
        Vertical,
        BoxClockwise,
        CircleClockwise
    }
    public partial class Form1 : Form
    {
        #region Variables 
        Graphics graphics;
        Pen pen;
        Shape shape;
        Movement move;
        Color color;
        int borderRight;
        int borderLeft = 0;
        int borderTop = 0;
        int borderBottom;

        int startX;
        int startY;
        int edge;
        #endregion

        public Form1()
        {
            InitializeComponent();
            graphics = PictureBox.CreateGraphics();
            borderRight = PictureBox.Width;
            borderBottom = PictureBox.Height;
            startX = PictureBox.Width / 2;
            startY = PictureBox.Height / 2;
        }

        #region User Input
        private void DimensionsTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(DimensionsTxtBox.Text, out edge);
        }
        private void ColorPBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                ColorPBox.BackColor = color;
            }
        }
        #endregion

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pen = new Pen(color, 5);
            graphics.Clear(Color.White);

            if (TriangleRadBtn.Checked)
            {
                shape = new Triangle(startX, startY, edge);
            }

            if (SquareRadBtn.Checked)
            {
                shape = new Square(startX, startY, edge);
            }

            if (CircleRadBtn.Checked)
            {
                shape = new Circle(startX, startY, edge);
            }

            if (HexagonRadBtn.Checked)
            {
                shape = new Hexagon(startX, startY, edge);
            }

            shape.Draw(graphics, pen);
        }

        #region Movement Buttons
        private void MoveYBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            move = Movement.Vertical;
        }
        private void MoveXBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            move = Movement.Horizontal;
        }
        private void MoveBoxClockWiseBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            move = Movement.BoxClockwise;
        }
        private void MoveCircleClockwiseBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Timer related stuff
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            switch (move)
            {
                case Movement.Horizontal:
                    shape.MoveHorizontaly(graphics, pen, borderRight, borderLeft);
                    break;
                case Movement.Vertical:
                    shape.MoveVerticaly(graphics, pen, borderTop, borderBottom);
                    break;
                case Movement.BoxClockwise:
                    shape.MoveBoxClockwise(graphics, pen, borderRight, borderBottom, borderLeft, borderTop);
                    break;
            }
        }
        private void FasterMoveRateBtn_Click(object sender, EventArgs e)
        {
            if (timer1.Interval == 50)
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

    }
}
