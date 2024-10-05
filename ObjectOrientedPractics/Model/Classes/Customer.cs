using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// ID покупателя.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Хранит ID покупателя. Только для чтения.
        /// </summary>
        public int Id
        { get { return _id; } }

        /// <summary>
        /// Количество покупателей. Статично.
        /// </summary>
        private static int _amountOfCustomers = 0;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _name;
        /// <summary>
        /// Хранит полное имя покупателя. Не более 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, Name))
                    _name = value;
            }
        }

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Хранит адрес покупателя. Является объектом класса <see cref="Classes.Address"/>.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Корзина.
        /// </summary>
        private Cart _cart;
        /// <summary>
        /// Хранит данные о корзине. Является объектом класса <see cref="Classes.Cart"/>.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Спиок заказов покупателя.
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Хранит Спиок обектов вида <see cref="Model.Classes.Order"/>.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна/регион. Не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Не более 50 символов.</param>
        /// <param name="street">Улица. Не более 100 символов.</param>
        /// <param name="building">Номер дома. Не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не более 10 символов.</param>
        public Customer(string name, string index, string country, string city, string street, string building, string apartment)
        {
            _id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = name;
            Address = new Address(index, country, city, street, building, apartment);
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Объект класса <see cref="Classes.Address"/>.</param>
        public Customer (string name, Address address)
        {
            _id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = name;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = "";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();

        }
    }
}
