﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapes.Movement_Interfaces
{
    interface IMoveHorizontaly
    {
        void MoveHorizontaly(Graphics g, Pen pen, int borderRight, int borderLeft);
    }
}
