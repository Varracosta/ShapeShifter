using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapes
{
    class Triangle : Shape
    {
        private int _edge;
        private Point[] vertices = new Point[3];
        public Triangle(int x, int y, int edge)
        {
            _edge = edge;

            vertices[0] = new Point(x, y);
            vertices[1] = new Point(x + edge / 2, y + edge);
            vertices[2] = new Point(x - edge / 2, y + edge);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawPolygon(pen, vertices);
        }

        public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        {
            if (movingRight)
            {
                vertices[0].X += 10;
                vertices[1].X += 10;
                vertices[2].X += 10;
            }

            if (!movingRight)
            {
                vertices[0].X -= 10;
                vertices[1].X -= 10;
                vertices[2].X -= 10;
            }

            if (vertices[1].X == borderRight)
                movingRight = !movingRight;

            if (vertices[2].X == borderLeft)
                movingRight = true;

            g.DrawPolygon(pen, vertices);
        }

        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            if (movingDown)
            {
                vertices[0].Y += 10;
                vertices[1].Y += 10;
                vertices[2].Y += 10;
            }

            if (!movingDown)
            {
                vertices[0].Y -= 10;
                vertices[1].Y -= 10;
                vertices[2].Y -= 10;
            }

            if (vertices[2].Y == borderBottom)
                movingDown = !movingDown;

            if (vertices[0].Y == borderTop)
                movingDown = true;

            g.DrawPolygon(pen, vertices);
        }

        //public override void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void MoveY(Graphics g, Pen pen)
        //{
        //    vertices[0].Y += 10;
        //    vertices[1].Y += 10;
        //    vertices[2].Y += 10;

        //    g.DrawPolygon(pen, vertices);
        //}
    }
}
