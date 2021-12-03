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
            throw new NotImplementedException();
        }
        public override void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom)
        {
            throw new NotImplementedException();
        }

        public override void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop)
        {
            throw new NotImplementedException();
        }


    }
}
