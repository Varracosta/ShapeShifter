using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapes.Movement_Interfaces
{
    interface IMoveCircleClockwise
    {
        void MoveCircleClockwise(Graphics g, Pen pen, int radius);
    }
}
