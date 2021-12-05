using System.Drawing;

namespace SimpleShapes.Shapes
{
    class Triangle : Shape
    {
        private Point[] vertices = new Point[3];    //stores vertices coordinates of a shape
        public Triangle(int x, int y, int edge)
        {
            EdgeOrDiameter = edge;
            X = x;
            Y = y - edge / 2;

            vertices[0] = new Point(X, Y);
            vertices[1] = new Point(X + edge / 2, Y + edge);
            vertices[2] = new Point(X - edge / 2, Y + edge);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawPolygon(pen, vertices);
        }
        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (MovingRight)
                MoveVerticesXAxis(vertices, 10);

            if (!MovingRight)
                MoveVerticesXAxis(vertices, -10);

            if (vertices[1].X >= borderRight)
                MovingRight = !MovingRight;

            if (vertices[2].X <= borderLeft)
                MovingRight = true;

            g.DrawPolygon(pen, vertices);
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (MovingDown)
                MoveVerticesYAxis(vertices, 10);

            if (!MovingDown)
                MoveVerticesYAxis(vertices, -10);

            if (vertices[2].Y >= borderBottom)
                MovingDown = !MovingDown;

            if (vertices[0].Y <= borderTop)
                MovingDown = true;

            g.DrawPolygon(pen, vertices);
        }
        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            if (MovingRight)
                MoveVerticesXAxis(vertices, 10);

            if (vertices[1].X >= borderRight)
            {
                MoveVerticesYAxis(vertices, 10);
                MovingRight = false;
            }

            if (vertices[1].Y >= borderBottom)
            {
                MoveVerticesXAxis(vertices, -10);
                MovingDown = false;
            }

            if (vertices[2].X <= borderLeft)
                MoveVerticesYAxis(vertices, -10);

            if (vertices[0].Y <= borderTop)
                MovingRight = true;

            g.DrawPolygon(pen, vertices);
        }
        public override void MoveCircleClockwise(Graphics g, Pen pen, int radius)
        {
            MoveVerticesCircular(vertices);

            g.DrawPolygon(pen, vertices);
        }
    }
}
