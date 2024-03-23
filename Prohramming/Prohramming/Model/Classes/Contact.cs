using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Prohramming.Model.Classes
{
    public class Contact
    {
        private string _surname;
        public string Surname 
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }
        private string _name;
        public string Name 
        { 
            get {  return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }
        private long _phoneNumber;
        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                Validator.AssertValueInRange(value, 100000000000, 1000000000000, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }
        private bool AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (var item in value)
            {
                if ( (item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z') )
                    continue;
                else
                    throw new ArgumentException($"Используйте символы латиского алфавита в свойстве {propertyName}");
            }
            return true;
        }
        public Contact(string surname, string name, long phoneNumber)
        {
            Surname = surname;
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public Contact () { }
    }
}
