using System;
using System.Drawing;

namespace SimpleShapes.Shapes
{
    class Circle : Shape
    {
        public Circle(int x, int y, int diameter)
        {
            X = x - diameter / 2;
            Y = y - diameter / 2;
            EdgeOrDiameter = diameter;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, X, Y, EdgeOrDiameter, EdgeOrDiameter);
        }

        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (MovingRight)
                X += 10;

            if (!MovingRight)
                X -= 10;

            if (X + EdgeOrDiameter >= borderRight)
                MovingRight = !MovingRight;

            if (X <= borderLeft)
                MovingRight = true;

            g.DrawEllipse(pen, X, Y, EdgeOrDiameter, EdgeOrDiameter);
        }

        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (MovingDown)
                Y += 10;

            if (!MovingDown)
                Y -= 10;

            if (Y + EdgeOrDiameter >= borderBottom)
                MovingDown = !MovingDown;

            if (Y <= borderTop)
                MovingDown = true;

            g.DrawEllipse(pen, X, Y, EdgeOrDiameter, EdgeOrDiameter);
        }
        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            if (MovingRight)
                X += 10;

            if (X + EdgeOrDiameter >= borderRight)
            {
                Y += 10;
                MovingRight = false;
            }

            if (Y + EdgeOrDiameter >= borderBottom)
            {
                X -= 10;
                MovingDown = false;
            }

            if (X <= borderLeft)
                Y -= 10;

            if (Y <= borderTop)
                MovingRight = true;

            g.DrawEllipse(pen, X, Y, EdgeOrDiameter, EdgeOrDiameter);
        }

        public override void MoveCircleClockwise(Graphics g, Pen pen, int radius)
        {
            X += (int)(5 * Math.Cos(Angle));
            Y += (int)(5 * Math.Sin(Angle));
            Angle += 0.1;

            g.DrawEllipse(pen, X, Y, EdgeOrDiameter, EdgeOrDiameter);
        }
    }
}
