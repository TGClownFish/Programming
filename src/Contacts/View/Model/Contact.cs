
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
        /// Хранит номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит адрес электронной почты.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задаёт имя. Должен быть не больше 100 символов.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт номер телефона. Должен включать в себя только цифры и знаки + - ( )
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты. Должен включать символ @
        /// </summary>
        public string Email { get; set; }

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