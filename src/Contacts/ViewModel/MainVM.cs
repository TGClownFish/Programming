using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Хранит поля и методы, нужные для объединания View и Model.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит данные о выбранном контакте.
        /// </summary>
        private Contact? _selectedContact = null;

        /// <summary>
        /// Во время редактирования контакта, хранит его позицию.
        /// </summary>
        private int _indexOfEditedContact = -1;

        /// <summary>
        /// Хранит список контактов.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Contact> _contacts = new();

        /// <summary>
        /// Хранит true, если программа в режиме редактирования контакта.
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsReadOnly))]
        private bool _isEditing = false;

        /// <summary>
        /// Хранаит true, если программа в режиме добавления контакта.
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsReadOnly))]
        private bool _isAdding = false;

        /// <summary>
        /// Хранит и возвращает выбранный контакт.
        /// </summary>
        public Contact? SelectedContact
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
        /// Возвращает true, если программа в режиме добавления или редактирования контакта.
        /// </summary>
        public bool IsReadOnly => !(IsAdding || IsEditing);

        /// <summary>
        /// Во время редактирования контакта, хранит и возвращает его позицию.
        /// </summary>
        public int IndexOfEditedContact
        {
            get => _indexOfEditedContact;
            set => _indexOfEditedContact = value >= -1 ? value : _indexOfEditedContact;
        }

        /// <summary>
        /// Начинает добавление контакта.
        /// </summary>
        [RelayCommand]
        private void Add()
        {
            SelectedContact = new Contact();
            IsAdding = true;
        }

        /// <summary>
        /// Удалает контакт.
        /// </summary>
        [RelayCommand]
        private void Remove() => Contacts.Remove(SelectedContact);

        /// <summary>
        /// Начинает редактирование контакта.
        /// </summary>
        [RelayCommand]
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
        [RelayCommand]
        private void Load() => Contacts = ContactSerializer.Deserialize();

        /// <summary>
        /// Сохраняет контакты в файл.
        /// </summary>
        [RelayCommand]
        private void Save() => ContactSerializer.Serialize(Contacts);

        /// <summary>
        /// Подтверждает изменения, сделанные при редактирование или добавлении контакта.
        /// </summary>
        [RelayCommand]
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
    }
}