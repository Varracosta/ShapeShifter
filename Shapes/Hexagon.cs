using System.Drawing;

namespace SimpleShapes.Shapes
{
    class Hexagon : Shape
    {
        private Point[] vertices = new Point[6];  //stores vertices coordinates of a shape

        public Hexagon(int x, int y, int edge)
        {
            EdgeOrDiameter = edge;
            X = x - edge / 2;
            Y = y - edge;

            vertices[0] = new Point(X, Y);
            vertices[1] = new Point(X + edge, Y);
            vertices[2] = new Point(X + (int)(edge * 1.5), Y + edge);
            vertices[3] = new Point(X + edge, Y + edge * 2);
            vertices[4] = new Point(X, Y + edge * 2);
            vertices[5] = new Point(X - edge / 2, Y + edge);
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

            if (vertices[2].X >= borderRight)
                MovingRight = !MovingRight;

            if (vertices[5].X <= borderLeft)
                MovingRight = true;

            g.DrawPolygon(pen, vertices);
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (MovingDown)
                MoveVerticesYAxis(vertices, 10);

            if (!MovingDown)
                MoveVerticesYAxis(vertices, -10);

            if (vertices[4].Y >= borderBottom)
                MovingDown = !MovingDown;

            if (vertices[0].Y <= borderTop)
                MovingDown = true;

            g.DrawPolygon(pen, vertices);
        }
        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            if (MovingRight)
                MoveVerticesXAxis(vertices, 10);

            if (vertices[2].X >= borderRight)
            {
                MoveVerticesYAxis(vertices, 10);
                MovingRight = false;
            }

            if (vertices[4].Y >= borderBottom)
            {
                MoveVerticesXAxis(vertices, -10);
                MovingDown = false;
            }

            if (vertices[5].X <= borderLeft)
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
