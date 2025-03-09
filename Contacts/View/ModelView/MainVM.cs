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
        private Contact _curentContact;
        /// <summary>
        /// Хранит и возвращает данные о выбранном контакте.
        /// </summary>
        public Contact CurentContact 
        {
            get { return _curentContact; }
            set 
            { 
                _curentContact = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Хранит и возвращает команду загрузки.
        /// </summary>
        public LoadCommand LoadCommand { get; }

        /// <summary>
        /// Хранит и возвращает команду сохранения.
        /// </summary>
        public SaveCommand SaveCommand { get; }
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Создаёт объект класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurentContact = new Contact();
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
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
