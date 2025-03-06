using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using View.Model.Services;

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

        private LoadCommand loadCommand;
        public LoadCommand LoadCommand
        {
            get
            {
                return loadCommand ?? (loadCommand = new LoadCommand(
                    obj =>
                    {
                        Contact contact = obj as Contact;
                        CurentContact = ContactSerializer.Deserialize();
                    },
                    (obj) => true
                ));
            }
        }
        private SaveCommand saveCommand;
        public SaveCommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new SaveCommand(
                    obj =>
                    {
                        Contact contact = obj as Contact;
                        ContactSerializer.Serialize(CurentContact);
                    },
                    (obj) => true
                ));
            }
        }
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
