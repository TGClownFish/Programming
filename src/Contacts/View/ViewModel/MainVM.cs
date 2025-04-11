using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.ModelView.Commands;

namespace View.ModelView
{
    /// <summary>
    /// Хранит поля и методы, нужные для объединания View и Model.
    /// </summary>
    public class MainVM : INotifyPropertyChanged, IDataErrorInfo
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
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        private bool _isNameValid = true;

        private bool _isPhoneNumberValid = true;

        private bool _isEmailValid = true;

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
        /// Хранит и возвращает данные о выбранном контакте.
        /// </summary>
        public Contact? SelectedContact
        { 
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                IsAdding = false;
                IsEditing = false;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            }
        }
        public string Name
        {
            get => SelectedContact?.Name;
            set
            {
                if (SelectedContact != null)
                {
                    SelectedContact.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string PhoneNumber
        {
            get => SelectedContact?.PhoneNumber;
            set
            {
                if (SelectedContact != null)
                {
                    SelectedContact.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get => SelectedContact?.Email;
            set
            {
                if (SelectedContact != null)
                {
                    SelectedContact.Email = value;
                    OnPropertyChanged();
                }
            }
        }


        /// <summary>
        /// Хранит и возвращает список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged();
            }
        }

        public bool IsNameValid
        {
            get => _isNameValid;
            set
            {
                _isNameValid = value;
                OnPropertyChanged(nameof(IsContactValid));
            }
        }

        public bool IsPhoneNumberValid
        {
            get => _isPhoneNumberValid;
            set
            {
                _isPhoneNumberValid = value;
                OnPropertyChanged(nameof(IsContactValid));
            }
        }

        public bool IsEmailValid
        {
            get => _isEmailValid;
            set
            {
                _isEmailValid = value;
                OnPropertyChanged(nameof(IsContactValid));
            }
        }

        public bool IsContactValid => (IsNameValid && IsPhoneNumberValid && IsEmailValid);

        /// <summary>
        /// Хранит и возвращает true, если программа в режиме редактирования контакта.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set 
            { 
                _isEditing = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        /// <summary>
        /// Хранит и возвращает true, если программа в режиме добавления контакта.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set 
            { 
                _isAdding = value; 
                OnPropertyChanged(nameof(IsReadOnly));
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
                if (_loadCommand == null)
                    _loadCommand = new LoadCommand(this);
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
                if (_saveCommand == null)
                    _saveCommand = new SaveCommand(this);
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
                if (_applyCommand == null)
                    _applyCommand = new ApplyCommand(this);
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
                if (_addCommand == null)
                        _addCommand = new AddCommand(this);
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
                if (_removeCommand == null)
                        _removeCommand = new RemoveCommand(this);
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
                if (_editCommand == null)
                    _editCommand = new EditCommand(this);
                return _editCommand;
            }
        }
        public string Error => "";

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;

                switch (columnName)
                {
                    case nameof(Name):
                        if (Name == null)
                            break;
                        IsNameValid = true;
                        if (Name.Length > 3)
                        {
                            error = "The name must be less than 50 characters.";
                            IsNameValid = false;
                            break;
                        }
                        break;
                    case nameof(PhoneNumber):
                        if (PhoneNumber == null)
                            break;
                        IsPhoneNumberValid = true;
                        if (PhoneNumber.Length > 100)
                        {
                            error = "The phone number must be less than 100 characters.";
                            IsPhoneNumberValid = false;
                            break;
                        }
                        foreach (char i in PhoneNumber)
                        {
                            if (!"0123456789+-() ".Contains(i))
                            {
                                error = "The email must contain digits or symbols +-().";
                                IsPhoneNumberValid = false;
                                break;
                            }
                        }
                        
                        break;
                    case nameof(Email):
                        if (Email == null)
                            break;
                        IsEmailValid = true;
                        if (Email.Length > 100)
                        {
                            error = "The phone number must be less than 100 characters.";
                            IsEmailValid = false;
                            break;
                        }
                        if (!Email.Contains("@"))
                        {
                            error = "The email must contain the @ symbol.";
                            IsEmailValid = false;
                            break;
                        }
                        break;
                }
                return error;
            }
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