using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public class Rectangle
    {
        private int _id;
        public int Id
        { 
            get { return _id; } 
        }
        private double _length;
        public double Length
        {
            get{return _length;}
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
        private double _width;
        public double Width
        {
            get{return _width;}
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }
        private string _colour;
        public string Colour 
        { 
            get { return _colour; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Colour));
                _colour = value;
            }
        }
        public Point2D Center { get; set; }

        private static int _allRectanglesCount;
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        public Rectangle (double length, double width, string colour, Point2D center)
        {
            _id = _allRectanglesCount;
            Length = length;
            Width = width;
            Colour = colour;
            Center = center;
            _allRectanglesCount++;
        }
        public Rectangle () 
        {
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
    }
}
