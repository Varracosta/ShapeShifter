using System;
using SimpleShapes.Movement_Interfaces;
using System.Drawing;

namespace SimpleShapes.Shapes
{
    abstract class Shape : IMoveHorizontaly, IMoveVerticaly, IMoveBoxClockwise, IMoveCircleClockwise
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected double Angle { get; set; }
        protected int EdgeOrDiameter { get; set; }
        protected bool MovingRight { get; set; } = true;
        protected bool MovingDown { get; set; }

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
                vertices[i].X += (int)(5 * Math.Cos(Angle));
                vertices[i].Y += (int)(5 * Math.Sin(Angle));
            }
            Angle += 0.1;
        }
    }
}
