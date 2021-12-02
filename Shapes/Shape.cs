using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SimpleShapes.Movement_Interfaces;

namespace SimpleShapes
{
    abstract class Shape : IMoveHorizontaly, IMoveVerticaly
    {
        public bool movingRight = true;
        p bool movingDown = true;
        public abstract void Draw(Graphics g, Pen pen);
        public abstract void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft);
        public abstract void MoveVerticaly(Graphics g, Pen pen, int borderTop, int borderBottom);
    }
}
