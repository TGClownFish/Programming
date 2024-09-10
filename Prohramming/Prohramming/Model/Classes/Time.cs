using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        private int _hour;
        public int Hour
        {
            get { return _hour; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hour));
                _hour = value;
            }
        }
        private int _minute;
        public int Minute
        {
            get { return _minute; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minute));
                _minute = value;
            }
        }
        private int _second;
        public int Second
        {
            get { return _second; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Second));
                _second = value;
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
