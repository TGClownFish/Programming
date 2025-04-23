using System.Collections.ObjectModel;
using View.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Хранит поля и методы, нужные для объединания View и Model.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит данные о выбранном контакте.
        /// </summary>
        private Contact _selectedContact = null;

        /// <summary>
        /// Во время редактирования контакта, хранит его позицию.
        /// </summary>
        private int _indexOfEditedContact = -1;

        /// <summary>
        /// Хранит список контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts = new();

        /// <summary>
        /// Хранит true, если программа в режиме редактирования контакта.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Хранаит true, если программа в режиме добавления контакта.
        /// </summary>
        private bool _isAdding = false;

        /// <summary>
        /// Хранит и возвращает выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                SetProperty(ref _selectedContact, value);
                IsAdding = false;
                IsEditing = false;
            }
        }

        /// <summary>
        /// Хранит и возвращает список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set => SetProperty(ref _contacts, value);
        }

        /// <summary>
        /// Хранит и возвращает true, если программа в режиме редактирования контакта.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set => SetProperty(ref _isEditing, value, nameof(IsReadOnly));
        }

        /// <summary>
        /// Хранит и возвращает true, если программа в режиме добавления контакта.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set => SetProperty(ref _isAdding, value, nameof(IsReadOnly));
        }

        /// <summary>
        /// Возвращает true, если программа в режиме добавления или редактирования контакта.
        /// </summary>
        public bool IsReadOnly => !(IsAdding || IsEditing);

        /// <summary>
        /// Во время редактирования контакта, хранит и возвращает его позицию.
        /// </summary>
        public int IndexOfEditedContact
        {
            get => _indexOfEditedContact;
            set
            {
                if ( value >= -1)
                    _indexOfEditedContact = value;
            }
        }

        /// <summary>
        /// Возвращает команду добавления. 
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду удаления.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Хранит и возвращает команду загрузки.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Возвращает команду сохранения.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Возвращает команду подтверждения. 
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Начинает добавление контакта.
        /// </summary>
        private void Add()
        {
            SelectedContact = new Contact();
            IsAdding = true;
        }

        /// <summary>
        /// Удалает контакт.
        /// </summary>
        private void Remove() => Contacts.Remove(SelectedContact);

        /// <summary>
        /// Начинает редактирование контакта.
        /// </summary>
        private void Edit()
        {
            if (IsReadOnly == true && SelectedContact != null)
            {
                IndexOfEditedContact = Contacts.IndexOf(SelectedContact);
                SelectedContact = new Contact(SelectedContact);
                IsEditing = true;
            }
        }
        /// <summary>
        /// Загружает контакты из файла.
        /// </summary>
        private void Load() => Contacts = ContactSerializer.Deserialize(); 

        /// <summary>
        /// Сохраняет контакты в файл.
        /// </summary>
        private void Save() => ContactSerializer.Serialize(Contacts);

        /// <summary>
        /// Подтверждает изменения, сделанные при редактирование или добавлении контакта.
        /// </summary>
        private void Apply()
        {
            if (IsEditing)
            {
                Contacts[IndexOfEditedContact] = SelectedContact;
                IndexOfEditedContact = -1;
                IsEditing = false;
            }
            if (IsAdding)
            {
                Contacts.Add(new Contact(SelectedContact));
                SelectedContact = Contacts.Last();
                IsAdding = false;
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            AddCommand = new RelayCommand(Add);
            RemoveCommand = new RelayCommand(Remove);
            EditCommand = new RelayCommand(Edit);
            LoadCommand = new RelayCommand(Load);
            SaveCommand = new RelayCommand(Save);
            ApplyCommand = new RelayCommand(Apply);
        }
    }
}