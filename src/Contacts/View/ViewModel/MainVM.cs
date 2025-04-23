using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using View.Model;
using View.ViewModel.Commands;
using CommunityToolkit.Mvvm.ComponentModel;

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
        /// Хранит команду загрузки.
        /// </summary>
        private LoadCommand _loadCommand;

        /// <summary>
        /// Хранит команду сохранения.
        /// </summary>
        private SaveCommand _saveCommand;

        /// <summary>
        /// Хранит команду добавления.
        /// </summary>
        private AddCommand _addCommand;

        /// <summary>
        /// Хранит команду удаления.
        /// </summary>
        private RemoveCommand _removeCommand;

        /// <summary>
        /// Хранит команду редактирования.
        /// </summary>
        private EditCommand _editCommand;

        /// <summary>
        /// Хранит команду подтверждения.
        /// </summary>
        private ApplyCommand _applyCommand;

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
        /// Хранит и возвращает команду загрузки.
        /// </summary>
        public LoadCommand LoadCommand
        {
            get
            {
                _loadCommand ??= new LoadCommand(this);
                return _loadCommand;
            }
        }

        /// <summary>
        /// Хранит и возвращает команду сохранения.
        /// </summary>
        public SaveCommand SaveCommand
        {
            get
            {
                _saveCommand ??= new SaveCommand(this);
                return _saveCommand;
            }
        }

        /// <summary>
        /// Хранит и возвращает команду подтверждения. 
        /// </summary>
        public ApplyCommand ApplyCommand
        {
            get
            {
                _applyCommand ??= new ApplyCommand(this);
                return _applyCommand;
            }
        }

        /// <summary>
        /// Хранит и возвращает команду добавления. 
        /// </summary>
        public AddCommand AddCommand
        {
            get
            {
                _addCommand ??= new AddCommand(this);
                return _addCommand;
            }
        }

        /// <summary>
        /// Хранит и возвращает команду удаления.
        /// </summary>
        public RemoveCommand RemoveCommand
        {
            get
            {
                _removeCommand ??= new RemoveCommand(this);
                return _removeCommand;
            }
        }

        /// <summary>
        /// Хранит и возвращает команду редактирования.
        /// </summary>
        public EditCommand EditCommand
        {
            get
            {
                _editCommand ??= new EditCommand(this);
                return _editCommand;
            }
        }
    }
}