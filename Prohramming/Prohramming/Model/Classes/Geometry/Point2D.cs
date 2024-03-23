using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public class Point2D
    {
        private double _x;
        public double X 
        {
            get { return _x; } 
            private set 
            {
                Validator.AssertValueInRange(value, -10000, 10000, "X");
                _x = value; 
            }
        }
        private double _y;
        public double Y
        {
            get { return _y; }
            private set
            {
                Validator.AssertValueInRange(value, -10000, 10000, "Y");
                _y = value;
            }
        }
public Point2D (double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point2D () { }
    }
}
