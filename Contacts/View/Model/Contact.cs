using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит имя.
        /// </summary>
        private string _name;
        /// <summary>
        /// Возвращает и задаёт имя. Должен быть не больше 100 символов.
        /// </summary>
        public string Name 
        { 
            get { return _name; } 
            set
            {
                _name = value;
                IsChanged = true;
            }
        }
        /// <summary>
        /// Хранит номер телефона.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Возвращает и задаёт номер телефона. Должен включать в себя только цифры и знаки + - ( )
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                IsChanged = true;
            }
        }

        /// <summary>
        /// Хранит адрес электронной почты.
        /// </summary>
        private string _email;
        /// <summary>
        /// Возвращает и задаёт адрес электронной почты. Должен включать символ @
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                IsChanged = true;
            }
        }

        /// <summary>
        /// Возвращает true, если все значения в классе пусты.
        /// </summary>
        public bool IsEmpty
        {
            get => Name == "" && PhoneNumber == "" && Email == "";
        }

        /// <summary>
        /// Хранит, был ли класс изменён.
        /// </summary>
        private bool _isChanged;
        /// <summary>
        /// Возвращает true если класс был изменён
        /// </summary>
        public bool IsChanged
        {
            get => _isChanged;
            private set => _isChanged = value;
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
            IsChanged = true;
        }
        /// <summary>
        /// Создаёт пустой объект класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
            IsChanged = false;
        }
    }
}
