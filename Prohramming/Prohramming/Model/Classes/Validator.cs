using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public static class Validator
    {
        public static bool AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
                throw new ArgumentException($"Введите значение выше нуля в свойстве {propertyName}");
            return true;
        }
        public static bool AssertOnPositiveValue(double value, string propertyName)
        {
            if (value.CompareTo(0.0) < 0)
                throw new ArgumentException($"Введите значение выше нуля в свойстве {propertyName}");
            return true;
        }
        //Validator.AssertOnPositiveValue(value, "");
        public static bool AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Введите значение выше {min} и ниже {max} в свойстве {propertyName}");
            return true;
        }
        public static bool AssertValueInRange(long value, long min, long max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Введите значение выше {min} и ниже {max} в свойстве {propertyName}");
            return true;
        }
        public static bool AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Введите значение выше {min} и ниже {max} в свойстве {propertyName}");
            return true;
        }
        //Validator.AssertValueInRange (value, 0, 1, "");
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
        //Validator.AssertStringContainsOnlyLetters(value, "");
    }
}
