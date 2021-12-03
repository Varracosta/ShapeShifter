using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleShapes.Movement_Interfaces;
using System.Drawing;

namespace SimpleShapes.Shapes
{
    abstract class Shape : IMoveHorizontaly, IMoveVerticaly, IMoveBoxClockwise, IMoveCircleClockwise
    {
        public bool movingRight = true;
        public bool movingDown;
        public double a;
        public abstract void Draw(Graphics g, Pen pen);
        public abstract void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft);
        public abstract void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom);
        public abstract void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop);
        public abstract void MoveCircleClockwise(Graphics g, Pen pen, int radius);
        public void MoveVerticesXAxis(Point[] vertices, int value)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].X += value;
            }
        }
        public void MoveVerticesYAxis(Point[] vertices, int value)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].Y += value;
            }
        }
        public void MoveVerticesCircular(Point[] vertices)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].X += (int)(5 * Math.Cos(a));
                vertices[i].Y += (int)(5 * Math.Sin(a));
            }
            a += 0.1;
        }
    }
}
