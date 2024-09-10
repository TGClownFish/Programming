using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для валидации значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, является ли значение позитивным.
        /// </summary>
        /// <param name="value">Значение в котором проводится проверка.</param>
        /// <param name="propertyName">Название поля в котором проводится проверка.</param>
        /// <returns>Возвращает true, если значение выше или равно нулю.</returns>
        /// <exception cref="ArgumentException">Если значение ниже нуля.</exception>
        public static bool AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
                throw new ArgumentException($"Введите значение выше нуля в свойстве {propertyName}");
            return true;
        }

        /// <summary>
        /// Проверяет, является ли значение позитивным.
        /// </summary>
        /// <param name="value">Значение в котором проводится проверка.</param>
        /// <param name="propertyName">Название поля в котором проводится проверка.</param>
        /// <returns>Возвращает true, если значение выше или равно нулю.</returns>
        /// <exception cref="ArgumentException">Если значение ниже нуля.</exception>
        public static bool AssertOnPositiveValue(double value, string propertyName)
        {
            if (value.CompareTo(0.0) < 0)
                throw new ArgumentException($"Введите значение выше нуля в свойстве {propertyName}");
            return true;
        }

        /// <summary>
        /// Проверяет, находиться ли значение в определенном интревале.
        /// </summary>
        /// <param name="value">Значение в котором проводится проверка.</param>
        /// <param name="min">Нижняя граница интревала.</param>
        /// <param name="max">Верхняя граница интревала.</param>
        /// <param name="propertyName">Название поля в котором проводится проверка.</param>
        /// <returns>Возвращает true, если значение в границах интревала.</returns>
        /// <exception cref="ArgumentException">Если значение не в границах интревала.</exception>
        public static bool AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Введите значение выше {min} и ниже {max} в свойстве {propertyName}");
            return true;
        }
        /// <summary>
        /// Проверяет, находиться ли значение в определенном интревале.
        /// </summary>
        /// <param name="value">Значение в котором проводится проверка.</param>
        /// <param name="min">Нижняя граница интревала.</param>
        /// <param name="max">Верхняя граница интревала.</param>
        /// <param name="propertyName">Название поля в котором проводится проверка.</param>
        /// <returns>Возвращает true, если значение в границах интревала.</returns>
        /// <exception cref="ArgumentException">Если значение не в границах интревала.</exception>
        public static bool AssertValueInRange(long value, long min, long max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Введите значение выше {min} и ниже {max} в свойстве {propertyName}");
            return true;
        }
        /// <summary>
        /// Проверяет, находиться ли значение в определенном интревале.
        /// </summary>
        /// <param name="value">Значение в котором проводится проверка.</param>
        /// <param name="min">Нижняя граница интревала.</param>
        /// <param name="max">Верхняя граница интревала.</param>
        /// <param name="propertyName">Название поля в котором проводится проверка.</param>
        /// <returns>Возвращает true, если значение в границах интревала.</returns>
        /// <exception cref="ArgumentException">Если значение не в границах интревала.</exception>
        public static bool AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Введите значение выше {min} и ниже {max} в свойстве {propertyName}");
            return true;
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из символов латинского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Название поля в котором проводится проверка.</param>
        /// <returns>Возвращает true, если строка состоит только из символов латинского алфавита.</returns>
        /// <exception cref="ArgumentException">Если в строке есть другие символы.</exception>
        public static bool AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (var item in value)
            {
                if ((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z'))
                    continue;
                else
                    throw new ArgumentException($"Используйте символы латиского алфавита в свойстве {propertyName}");
            }
            return true;
        }
    }
}
