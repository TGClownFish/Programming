using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using View.Model;
using View.Model.Services;
using View.ModelView.Commands;

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
        private Contact? _curentContact;
        /// <summary>
        /// Хранит и возвращает данные о выбранном контакте.
        /// </summary>
        public Contact? CurentContact 
        {
            get => _curentContact; 
            set 
            { 
                _curentContact = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged();
            }
        }

        public bool ContactIsPicked => CurentContact != null;

        /// <summary>
        /// Хранит и возвращает команду загрузки.
        /// </summary>
        public LoadCommand LoadCommand { get; }
        /// <summary>
        /// Хранит и возвращает команду сохранения.
        /// </summary>
        public SaveCommand SaveCommand { get; }
        /// <summary>
        /// Хранит и возвращает команду подтверждения. 
        /// </summary>
        public ApplyCommand ApplyCommand { get; }
        /// <summary>
        /// Хранит и возвращает команду добавления. 
        /// </summary>
        public AddCommand AddCommand { get; }
        /// <summary>
        /// Хранит и возвращает команду удаления.
        /// </summary>
        public RemoveCommand RemoveCommand { get; }
        /// <summary>
        /// Хранит и возвращает команду редактирования.
        /// </summary>
        public EditCommand EditCommand { get; }

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

        /// <summary>
        /// Создаёт объект класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            CurentContact = null;
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
            ApplyCommand = new ApplyCommand(this);
            AddCommand = new AddCommand(this);
            RemoveCommand = new RemoveCommand(this);
            EditCommand = new EditCommand(this);
        }
    }
}
