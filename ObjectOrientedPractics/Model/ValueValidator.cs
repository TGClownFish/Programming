using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class ValueValidator
    {
        /// <summary>
        /// Проверяет, меньше ли длина строки, чем данное значение.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Значение, меньше которого должна быть строка </param>
        /// <param name="propertyName">Провреяемое поле</param>
        /// <returns>Возвращет true, если длина строки меньше или равно, чем данное значение</returns>
        /// <exception cref="ArgumentException">Если длина строки больше, чем данное значение</exception>
        public bool IsStringLessThan (string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
                throw new ArgumentException($"Значение поля {nameof(propertyName)} должно быть меньше или равно, чем {maxLength}");
            else
                return true;
        }
        public bool IsIntInffffff;//interval
    }
}
