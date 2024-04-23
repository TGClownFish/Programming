using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public static class Validator
    {
        public static bool IsShorterThan(string value, int size)
        {
            if (value.Length > size)
                throw new ArgumentException("");
            else
                return true;
        }
        public static bool IsPhoneNumber(string value)
        {
            if (value[0]!='+')
                throw new ArgumentException("");
            else
                for (int i = 1;  i < value.Length; i++)
                {
                    if (!Char.IsDigit(value[i]))
                        throw new ArgumentException("");
                }
            return true;
        }
    }
}
