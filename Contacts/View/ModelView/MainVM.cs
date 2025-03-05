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
        public Contact CurentContact { get; set; }
        public MainVM()
        {
            CurentContact = new Contact();
        }
    }
}
