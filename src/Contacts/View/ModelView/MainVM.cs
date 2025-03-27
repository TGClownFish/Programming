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
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит контакт, хранящий данные для текстбоксов.
        /// </summary>
        private Contact? _temporaryContact = null;

        /// <summary>
        /// Хранит данные о выбранном контакте
        /// </summary>
        private Contact? _selectedContact = null;

        /// <summary>
        /// Хранит список контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        /// <summary>
        /// Хранит true, если программа в режиме редактирования контакта.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Хранаит true, если программа в режиме добавления контакта.
        /// </summary>
        private bool _isAdding = false;

        /// <summary>
        /// Хранит и возвращает данные о выбранном контакте.
        /// </summary>
        public Contact? SelectedContact
        { 
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                _temporaryContact = null;
                IsAdding = false;
                IsEditing = false;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TemporaryContact));
                OnPropertyChanged(nameof(ContactIsPicked));
            }
        }

        /// <summary>
        /// Хранит и возвращает контакт, хранящий данные для текстбоксов.
        /// </summary>
        public Contact? TemporaryContact
        {
            get
            {
                if (_temporaryContact == null)
                {
                    return SelectedContact;
                }
                return _temporaryContact;
            }
            set
            {
                _temporaryContact = value;
                OnPropertyChanged();
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

        /// <summary>
        /// Возващает Возвращает true, если контакт выбран.
        /// </summary>
        public bool ContactIsPicked => SelectedContact != null;

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
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
            ApplyCommand = new ApplyCommand(this);
            AddCommand = new AddCommand(this);
            RemoveCommand = new RemoveCommand(this);
            EditCommand = new EditCommand(this);
        }
    }
}