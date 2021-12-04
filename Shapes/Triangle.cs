using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapes.Shapes
{
    class Triangle : Shape
    {
        private Point[] vertices = new Point[3];
        private int _edge;
        private int _x;
        private int _y;
        public Triangle(int x, int y, int edge)
        {
            _edge = edge;
            _x = x;
            _y = y - edge / 2;

            vertices[0] = new Point(_x, _y);
            vertices[1] = new Point(_x + edge / 2, _y + edge);
            vertices[2] = new Point(_x - edge / 2, _y + edge);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawPolygon(pen, vertices);
        }

        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (movingRight)
                MoveVerticesXAxis(vertices, 10);

            if (!movingRight)
                MoveVerticesXAxis(vertices, -10);

            if (vertices[1].X >= borderRight)
                movingRight = !movingRight;

            if (vertices[2].X <= borderLeft)
                movingRight = true;

            g.DrawPolygon(pen, vertices);
        }

        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (movingDown)
                MoveVerticesYAxis(vertices, 10);

            if (!movingDown)
                MoveVerticesYAxis(vertices, -10);

            if (vertices[2].Y >= borderBottom)
                movingDown = !movingDown;

            if (vertices[0].Y <= borderTop)
                movingDown = true;

            g.DrawPolygon(pen, vertices);
        }

        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            if (movingRight)
                MoveVerticesXAxis(vertices, 10);

            if (vertices[1].X + _edge >= borderRight)
            {
                MoveVerticesYAxis(vertices, 10);
                movingRight = false;
            }

            if (vertices[1].Y + _edge >= borderBottom)
            {
                MoveVerticesXAxis(vertices, -10);
                movingDown = false;
            }

            if (vertices[2].X <= borderLeft)
                MoveVerticesYAxis(vertices, -10);

            if (vertices[0].Y <= borderTop)
                movingRight = true;

            g.DrawPolygon(pen, vertices);
        }

        public override void MoveCircleClockwise(Graphics g, Pen pen, int radius)
        {
            MoveVerticesCircular(vertices);

            g.DrawPolygon(pen, vertices);
        }
    }
}
