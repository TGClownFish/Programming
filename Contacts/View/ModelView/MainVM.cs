using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using View.Model;
using View.Model.Services;

namespace View.ModelView
{
    /// <summary>
    /// Хранит поля, нужные для объединания View и Model.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        public Contact _curentContact;
        /// <summary>
        /// Хранит данные о контакте.
        /// </summary>
        public Contact CurentContact 
        {
            get { return _curentContact; }
            set 
            { 
                _curentContact = value;
                OnPropertyChanged("CurentContact");
            }
        }

        private LoadCommand loadCommand;
        public LoadCommand LoadCommand
        {
            get
            {
                return loadCommand ?? (loadCommand = new LoadCommand(
                    obj =>
                    {
                        CurentContact = ContactSerializer.Deserialize();
                    }
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
                        ContactSerializer.Serialize(CurentContact);
                    }
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
                OnPropertyChanged("Name");
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
                OnPropertyChanged("PhoneNumber");
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
                OnPropertyChanged("Emai");
            }
        }
        /// <summary>
        /// Создаёт объект класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurentContact = new Contact();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
