using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public partial class Contact: ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Хранит имя. Должен быть не больше 50 символов.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит номер телефона. 
        /// Должен быть не больше 100 символов и должен включать в себя только цифры и знаки + - ( ).
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит адрес электронной почты. 
        /// Должен быть не больше 100 символов и должен включать символ @.
        /// </summary>
        private string _email;

        /// <summary>
        /// Хранит true, если имя контакта введено правильно.
        /// </summary>
        [ObservableProperty]
        private bool _isNameValid = true;

        /// <summary>
        /// Хранит true, если телефонный номер контакта введен правильно.
        /// </summary>
        [ObservableProperty]
        private bool _isPhoneNumberValid = true;

        /// <summary>
        /// Хранит true, если электронная почта контакта введена правильно.
        /// </summary>
        [ObservableProperty]
        private bool _isEmailValid = true;

        /// <summary>
        /// Возвращает и задаёт имя. Должен быть не больше 50 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                IsNameValid = _name.Length >= 50;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона.
        /// Должен быть не больше 100 символов и должен включать в себя только цифры и знаки + - ( ).
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                if (value.Length <= 100)
                {
                    IsEmailValid = true;
                    foreach (var i in value)
                    {
                        if (!"0123456789+-() ".Contains(i))
                        {
                            IsEmailValid = false;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// Должен быть не больше 100 символов и должен включать символ @.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                IsEmailValid = _email == "" || (_email.Length <= 100 && _email.Contains('@'));
            }
        }

        /// <summary>
        /// Возвращает true, если все поля контакта введены правильно.
        /// </summary>
        public bool IsContactValid => (IsNameValid && IsPhoneNumberValid && IsEmailValid);

        /// <summary>
        /// Нужно для реализации интерфейса <see cref="IDataErrorInfo"/>, возвращает пустую строку.
        /// </summary>
        public string Error => "";

        /// <summary>
        /// Если поле контакта заполненно неправильно, 
        /// возвращает текст ошибки и менят значение в соответвующем булевом поле.
        /// </summary>
        /// <param name="columnName">Название проверяемого поля.</param>
        /// <returns>Текст ошибки.</returns>
        public string this[string columnName]
        {
            get
            {
                string error = "";

                switch (columnName)
                {
                    case nameof(Name):
                        if (Name == null)
                            break;
                        IsNameValid = true;
                        if (Name.Length > 50)
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
                        if (Email == null || Email == "")
                            break;
                        IsEmailValid = true;
                        if (Email.Length > 100)
                        {
                            error = "The phone number must be less than 100 characters.";
                            IsEmailValid = false;
                            break;
                        }
                        if (!Email.Contains('@'))
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
        /// Создаёт объект класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Адрес электронной почты.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создаёт пустой объект класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }

        /// <summary>
        /// Копирует объект класса <see cref="Contact"/> по образцу.
        /// </summary>
        /// <param name="contact">Копируемый объект.</param>
        public Contact(Contact contact)
        {
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }
    }
}