using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Возвращает и задаёт полное имя контакта. Должно быть не больше 150 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateBirth;
        /// <summary>
        /// Дата рождения. Не может быть выше текущего дня.
        /// </summary>
        public DateTime DateBirth
        { 
            get { return _dateBirth; } 
          set {  _dateBirth = value; } 
        }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Номер телефона. Должен начинаться с '+', остальные символы - цифры.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        /// <summary>
        /// Ссылка на страницу в соцсети.
        /// </summary>
        private string _link;
        /// <summary>
        /// Ссылка на страницу в соцсети. Нет валидации.
        /// </summary>
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }

        /// <summary>
        /// Создаёт экземляр класса Contact.
        /// </summary>
        /// <param name="fullName">Возвращает и задаёт полное имя контакта. Должно быть не больше 150 символов.</param>
        /// <param name="dateBirth">Дата рождения. Не может быть выше текущего дня..</param>
        /// <param name="phoneNumber">Номер телефона. Должен начинаться с '+', остальные символы - цифры.</param>
        /// <param name="link">Ссылка на страницу в соцсети. Нет валидации.</param>
        public Contact(string fullName, DateTime dateBirth, string phoneNumber, string link)
        {
            FullName = fullName;
            DateBirth = dateBirth;
            PhoneNumber = phoneNumber;
            Link = link;
        }

        /// <summary>
        /// Создаёт пустой экземляр класса Contact.
        /// </summary>
        public Contact() { }
    }
}
