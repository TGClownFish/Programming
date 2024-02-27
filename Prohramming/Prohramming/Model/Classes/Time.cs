using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Time
    {
        private int _hour;
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    _hour = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 0 и 23");
                }
            }
        }
        private int _minute;
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 0 и 60");
                }
            }
        }
        private int _second;
        public int Second
        {
            get { return _second; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _second = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 0 и 60");
                }
            }
        }
        public Time (int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Time () { }
    }
}
