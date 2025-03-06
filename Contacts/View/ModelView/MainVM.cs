using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ModelView
{
    /// <summary>
    /// Хранит поля, нужные для объединания View и Model.
    /// </summary>
    public class MainVM
    {
        /// <summary>
        /// Хранит данные о контакте.
        /// </summary>
        public Contact CurentContact { get; set; }
        /// <summary>
        /// Хранит данные об имени контакта.
        /// </summary>
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
        /// <summary>
        /// Хранит данные о телефонном номере контакта.
        /// </summary>
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
        /// <summary>
        /// Хранит данные об электронной почте контакта.
        /// </summary>
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
        /// <summary>
        /// Создаёт объект класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurentContact = new Contact();
        }
    }
}
