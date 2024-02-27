using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Contact
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private long _phoneNumber;
        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value >= 100000000000 && value < 1000000000000)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 100000000000 и 1000000000000");
                }
            }
        }
        public Contact(string lastName, string name, string surname, long phoneNumber)
        {
            LastName = lastName;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public Contact () { }
    }
}
