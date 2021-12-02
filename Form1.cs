using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapes
{
    public enum Movement
    {
        Horizontal,
        Vertical
    }
    public enum BasicShape
    {
        Square, 
        Triangle
    }
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Blue, 5);
        Shape shape;
        Movement move;
        int borderRight;
        int borderLeft = 0;
        int borderTop = 0;
        int borderBottom;

        int x = 60;
        int y = 10;
        int edge = 100;
       
        public Form1()
        {
            InitializeComponent();
            graphics = PictureBox.CreateGraphics();
            borderRight = PictureBox.Width;
            borderBottom = PictureBox.Height;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            graphics.Clear(Color.White);

            if (TriangleRadBtn.Checked)
            {
                shape = new Triangle(x, y, edge);
            }

            if (SquareRadBtn.Checked)
            {
                shape = new Square(x, y, edge);
            }

            shape.Draw(graphics, pen);
        }

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
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
