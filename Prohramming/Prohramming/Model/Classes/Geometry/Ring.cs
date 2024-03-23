using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public class Ring
    {
        public Point2D Center { get; set; }

        private int _innerRadius;
        public int InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (OuterRadius >= value)
                    _innerRadius = value;
                else
                    throw new ArgumentException("Значение Внешнего радиуса должно быть больше Внутреннего");
            }
        }
        private int _outerRadius;
        public int OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (InnerRadius <= value)
                   _outerRadius = value;
                else
                    throw new ArgumentException("Значение Внешнего радиуса должно быть больше Внутреннего");
            }
        }
        public double Area
        {
            get 
            {
                return ( Math.PI * Math.Pow(_outerRadius,2) ) - (Math.PI * Math.Pow(_innerRadius, 2)); 
            }
        }
        public Ring (Point2D center, int innerRadius, int outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
        public Ring () { }
    }
}
