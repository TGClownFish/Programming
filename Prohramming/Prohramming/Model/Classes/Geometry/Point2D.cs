﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public class Point2D
    {
        private int _x;
        public int X 
        {
            get { return _x; } 
            private set 
            {
                Validator.AssertOnPositiveValue(value, "X");
                _x = value; 
            }
        }
        private int _y;
        public int Y
        {
            get { return _y; }
            private set
            {
                Validator.AssertOnPositiveValue(value, "Y");
                _y = value;
            }
        }
public Point2D (int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point2D () { }
    }
}
