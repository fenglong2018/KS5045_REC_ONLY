﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lime上位机
{
    public class ListViewFN : ListView
    {
        public ListViewFN()
        {
            SetStyle(ControlStyles.DoubleBuffer |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
