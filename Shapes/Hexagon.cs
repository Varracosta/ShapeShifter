using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapes.Shapes
{
    class Hexagon : Shape
    {
        private Point[] vertices = new Point[6];
        private int _edge;
        private int _x;
        private int _y;
        public Hexagon(int x, int y, int edge)
        {
            _edge = edge;
            _x = x - edge / 2;
            _y = y - edge;

            vertices[0] = new Point(_x, _y);
            vertices[1] = new Point(_x + edge, _y);
            vertices[2] = new Point(_x + (int)(edge * 1.5), _y + edge);
            vertices[3] = new Point(_x + edge, _y + edge * 2);
            vertices[4] = new Point(_x, _y + edge * 2);
            vertices[5] = new Point(_x - edge / 2, _y + edge);
        }
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawPolygon(pen, vertices);
        }
        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (movingRight)
            {
                for (int i = 0; i < vertices.Length; i++)
                {
                    vertices[i].X += 10;
                }
            }

            if (!movingRight)
            {
                for (int i = 0; i < vertices.Length; i++)
                {
                    vertices[i].X -= 10;
                }
            }

            if (vertices[2].X >= borderRight)
                movingRight = !movingRight;

            if (vertices[5].X <= borderLeft)
                movingRight = true;

            g.DrawPolygon(pen, vertices);
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (movingDown)
            {
                for (int i = 0; i < vertices.Length; i++)
                {
                    vertices[i].Y += 10;
                }
            }

            if (!movingDown)
            {
                for (int i = 0; i < vertices.Length; i++)
                {
                    vertices[i].Y -= 10;
                }
            }

            if (vertices[4].Y >= borderBottom)
                movingDown = !movingDown;

            if (vertices[0].Y <= borderTop)
                movingDown = true;

            g.DrawPolygon(pen, vertices);
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
