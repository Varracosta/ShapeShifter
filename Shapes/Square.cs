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
        public int _x { get; set; }
        public int _y { get; set; }
        private int _edge;
        private double a;

        public Square(int x, int y, int edge)
        {
            _x = x - edge / 2;
            _y = y - edge / 2;
            _edge = edge;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, _x, _y, _edge, _edge);
        }

        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (movingRight)
                _x += 10;
            else
                _x -= 10;

            if (_x + _edge >= borderRight)
                movingRight = !movingRight;

            if (_x <= borderLeft)
                movingRight = true;

            g.DrawRectangle(pen, _x, _y, _edge, _edge);
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (movingDown)
                _y += 10;
            else
                _y -= 10;

            if (_y + _edge >= borderBottom)
                movingDown = !movingDown;

            if (_y <= borderTop)
                movingDown = true;

            g.DrawRectangle(pen, _x, _y, _edge, _edge);
        }
        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            //Was trying to create more elegant way to move a shape:

            //if (steps < maxSteps)
            //{
            //    pathMovement[counter] += 10;
            //    steps++;
            //}
            //else
            //    counter++;

            if (movingRight)
                _x += 10;

            if (_x + _edge >= borderRight)
            {
                _y += 10;
                movingRight = false;
            }

            if (_y + _edge >= borderBottom)
            {
                _x -= 10;
                movingDown = false;
            }

            if (_x <= borderLeft)
                _y -= 10;

            if (_y <= borderTop)
                movingRight = true;

            g.DrawRectangle(pen, _x, _y, _edge, _edge);
        }

        public override void MoveCircleClockwise(Graphics g, Pen pen, int radius)
        {
            _x += (int)(radius * Math.Cos(a));
            _y += (int)(radius * Math.Sin(a));

            a += 0.1;

            g.DrawRectangle(pen, _x, _y, _edge, _edge);
        }
    }
}
