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

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;
        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна быть положительна.
        /// </summary>
        public double Width
        {
            get{return _width;}
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _colour;
        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника. Должна состоять из букв латинского алфавита.
        /// </summary>
        public string Colour 
        { 
            get { return _colour; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Colour));
                _colour = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт координаты прямоугольника. Объект класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Хранит количество созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длинна. Должна быть положительна.</param>
        /// <param name="width">Ширина. Должна быть положительна.</param>
        /// <param name="colour">Цвет. Должен состоять из букв латинского алфавита.</param>
        /// <param name="center">Координаты центра. Объект класса <see cref="Point2D"/>.</param>
        public Rectangle (double length, double width, string colour, Point2D center)
        {
            _id = _allRectanglesCount;
            Length = length;
            Width = width;
            Colour = colour;
            Center = center;
            _allRectanglesCount++;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle () 
        {
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
    }
}
