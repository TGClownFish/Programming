using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        private string _name;
        public string Name 
        { 
            get { return _name; } 
            set
            {
                if (value.Length <= 50 )
                {
                    _name = value;
                }
            }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(value))
                {
                    _email = value;
                }
            }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                
            }
        }
        public Contact() { }
    }
}
