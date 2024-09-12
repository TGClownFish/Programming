using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит методы для вылидации полей.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет длинну строки.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Значение, с которым сравнивается длинна строки.</param>
        /// <param name="propertyName">Проверяемое поле.</param>
        /// <returns>Возвращет true, если длина строки меньше или равно данному значению.</returns>
        /// <exception cref="ArgumentException">Если длина строки больше, чем данное значение.</exception>
        public static bool AssertStringOnLength (string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
                throw new ArgumentException($"Длинна строки, хранящейся в поле {nameof(propertyName)} должна быть меньше или равно, чем {maxLength}.");
            else
                return true;
        }

        /// <summary>
        /// Проверяет число.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="minValue">Нижняя граница отрезка.</param>
        /// <param name="maxValue">Верхняя граница отрезка.</param>
        /// <param name="propertyName">Проверяемое поле.</param>
        /// <returns>Возвращает true, если число входит в отрезок (больше или равно меньшему значению и меньше или равно большему значению).</returns>
        /// <exception cref="ArgumentException">Если число не входит в отрезок.</exception>
        public static bool AssertIntegerOnBeeingInClosedInterval(int value, int minValue, int maxValue, string propertyName)
        {
            if (value <= minValue && value >= maxValue)
                throw new ArgumentException($"Значение, хранящееся в поле {nameof(propertyName)} не входит в отрезок [{minValue},{maxValue}].");
            else
                return true;
        }
    }
}
