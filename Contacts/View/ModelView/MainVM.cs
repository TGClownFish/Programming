using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ModelView
{
    public class MainVM
    {
        public string Name
        {
            get
            {
                return CurentContact.Name;
            }
            set
            {
                CurentContact.Name = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return CurentContact.PhoneNumber;
            }
            set
            {
                CurentContact.PhoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return CurentContact.Email;
            }
            set
            {
                CurentContact.Email = value;
            }
        }
        public Contact CurentContact { get; set; }
        public MainVM()
        {
            CurentContact = new Contact();
        }
    }
}
