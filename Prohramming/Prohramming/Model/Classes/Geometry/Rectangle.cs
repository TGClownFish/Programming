using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Хранит данные прямоугольников.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;
        /// <summary>
        /// Возвращает уникальный идентификатор объекта.
        /// </summary>
        public int Id
        { 
            get { return _id; } 
        }

        /// <summary>
        /// Длинна прямоугольника.
        /// </summary>
        private double _length;
        /// <summary>
        /// Возвращает и задаёт длинну прямоугольника. Должна быть положительна.
        /// </summary>
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
