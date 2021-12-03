using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapes.Shapes
{
    class Square : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int _edge;
        private double a;

        public Square(int x, int y, int edge)
        {
            X = x - edge / 2;
            Y = y - edge / 2;
            _edge = edge;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }

        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (movingRight)
                X += 10;
            else
                X -= 10;

            if (X + _edge >= borderRight)
                movingRight = !movingRight;

            if (X <= borderLeft)
                movingRight = true;

            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (movingDown)
                Y += 10;
            else
                Y -= 10;

            if (Y + _edge >= borderBottom)
                movingDown = !movingDown;

            if (Y <= borderTop)
                movingDown = true;

            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }
        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            if (movingRight)
                X += 10;

            if (X + _edge >= borderRight)
            {
                Y += 10;
                movingRight = false;
            }

            if(Y + _edge >= borderBottom)
            {
                X -= 10;
                movingDown = false;
            }

            if(X <= borderLeft)
                Y -= 10;

            if(Y <= borderTop)
                movingRight = true;

            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }

        public override void MoveCircleClockwise(Graphics g, Pen pen, int radius)
        {
            X += (int)(5 * Math.Cos(a));
            Y += (int)(5 * Math.Sin(a));

            a += 0.1;

            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }
    }
}
