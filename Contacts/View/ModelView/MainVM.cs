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
    /// Хранит поля и методы, нужные для объединания View и Model.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит данные о выбранном контакте
        /// </summary>
        public Contact _curentContact;
        /// <summary>
        /// Хранит и возвращает данные о выбранном контакте.
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

        /// <summary>
        /// Хранит команду загрузки.
        /// </summary>
        private LoadCommand loadCommand;
        /// <summary>
        /// Хранит и возвращает команду загрузки.
        /// </summary>
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

        /// <summary>
        /// Хранит команду сохранения.
        /// </summary>
        private SaveCommand saveCommand;
        /// <summary>
        /// Хранит и возвращает команду сохранения.
        /// </summary>
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
        /// Хранит и возвращает данные об имени контакта.
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
        /// Хранит и возвращает данные о телефонном номере контакта.
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
        /// Хранит и возвращает данные об электронной почте контакта.
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
                OnPropertyChanged("Email");
            }
        }
        /// <summary>
        /// Создаёт объект класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurentContact = new Contact();
        }

        /// <summary>
        /// Срабатывет, когда меняется свойство элемента.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Вызывает событие PropertyChanged.
        /// </summary>
        /// <param name="prop">Аргументы события.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
