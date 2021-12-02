using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapes
{
    class Square : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int _edge;

        public Square(int x, int y, int edge)
        {
            X = x;
            Y = y;
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

            if (!movingRight)
                X -= 10;

            if (X + _edge == borderRight)
                movingRight = !movingRight;

            if (X == borderLeft)
                movingRight = true;

            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if(movingDown)
                Y += 10;

            if (!movingDown)
                Y -= 10;

            if (Y + _edge == borderBottom)
                movingDown = !movingDown;

            if (Y == borderTop)
                movingDown = true;

            g.DrawRectangle(pen, X, Y, _edge, _edge);
        }
    }
}
