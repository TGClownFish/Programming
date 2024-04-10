using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Хранит данные о координатах точки в 2D пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private int _x;
        /// <summary>
        /// Возвращает и задаёт координату X. Должна быть положительна.
        /// </summary>
        public int X 
        {
            get { return _x; } 
            private set 
            {
                Validator.AssertOnPositiveValue(value, "X");
                _x = value; 
            }
        }

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;
        /// <summary>
        /// Возвращает и задаёт координату Y. Должна быть положительна.
        /// </summary>
        public int Y
        {
            get { return _y; }
            private set
            {
                Validator.AssertOnPositiveValue(value, "Y");
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Возвращает из задаёт координату X. Должна быть положительна.</param>
        /// <param name="y">Возвращает из задаёт координату Y. Должна быть положительна.</param>
        public Point2D (int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Создаёт пустой экземляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D () { }
    }
}

