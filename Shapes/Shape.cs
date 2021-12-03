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
        public abstract void Draw(Graphics g, Pen pen);
        public abstract void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft);
        public abstract void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom);
        public abstract void MoveBoxClockwise(Graphics g, Pen pen, int borderRight, int borderBottom, int borderLeft, int borderTop);
        public abstract void MoveCircleClockwise(Graphics g, Pen pen, int radius);
    }
}
