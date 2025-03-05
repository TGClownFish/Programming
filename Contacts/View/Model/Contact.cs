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
        /// Возвращает и задаёт имя. Должен быть не больше 50 символов.
        /// </summary>
        public string Name 
        { 
            get { return _name; } 
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"Неверное значение в поле {Name.GetType}");
                    
                }
                _name = value;
            }
        }
        /// <summary>
        /// Хранит номер телефона.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Возвращает и задаёт номер телефона. Должен быть в формате +7-ddd-ddd-dd-dd, где d это цифра.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value == "" || Regex.Match(value, 
                    @"^(\+7-[0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2})$").Success == true)
                {
                    _phoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Хранит адрес электронной почты.
        /// </summary>
        private string _email;
        /// <summary>
        /// Возвращает и задаёт адрес электронной почты. Должен быть в правильном формате адреса электронной почты.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value == "" || new EmailAddressAttribute().IsValid(value) == true)
                {
                    _email = value;
                }
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
    }
}
