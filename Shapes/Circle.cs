using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapes.Shapes
{
    class Circle : Shape
    {
        private int _x;
        private int _y;
        private int _diameter;
        public Circle(int x, int y, int diameter)
        {
            _x = x - diameter / 2;
            _y = y - diameter / 2;
            _diameter = diameter;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, _x, _y, _diameter, _diameter);
        }

        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (movingRight)
                _x += 10;

            if (!movingRight)
                _x -= 10;

            if (_x + _diameter >= borderRight)
                movingRight = !movingRight;

            if (_x <= borderLeft)
                movingRight = true;

            g.DrawEllipse(pen, _x, _y, _diameter, _diameter);
        }

        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (movingDown)
                _y += 10;

            if (!movingDown)
                _y -= 10;

            if (_y + _diameter >= borderBottom)
                movingDown = !movingDown;

            if (_y <= borderTop)
                movingDown = true;

            g.DrawEllipse(pen, _x, _y, _diameter, _diameter);
        }
        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            throw new NotImplementedException();
        }

        public override void MoveCircleClockwise(Graphics g, Pen pen, int radius)
        {
            throw new NotImplementedException();
        }
    }
}
