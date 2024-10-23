using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Model.Classes.Orders;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {

        /// <summary>
        /// Хранит ID покупателя. Только для чтения.
        /// </summary>
        public int Id { get; }

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
                if (ValueValidator.IsLessThanOrEqual(value, 200, Name))
                    _name = value;
            }
        }

        /// <summary>
        /// Хранит адрес покупателя. Является объектом класса <see cref="Classes.Address"/>.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Хранит данные о корзине. Является объектом класса <see cref="Classes.Cart"/>.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Хранит данные о скидках.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Хранит Спиок обектов вида <see cref="Orders.Order"/>.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Хранит данные о приоритетности покупателя.
        /// </summary>
        public bool IsPriority { get; set; }

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
            Id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = name;
            Address = new Address(index, country, city, street, building, apartment);
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>();
            Discounts.Add(new Discounts.PointsDiscount());
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Объект класса <see cref="Classes.Address"/>.</param>
        public Customer(string name, Address address)
        {
            Id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = name;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>();
            Discounts.Add(new Discounts.PointsDiscount());
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Объект класса <see cref="Classes.Address"/>.</param>
        /// <param name="isPriority">Приоритетность покупателя.</param>
        public Customer(string name, Address address, bool isPriority)
        {
            Id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = name;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = isPriority;
            Discounts= new List<IDiscount>();
            Discounts.Add(new Discounts.PointsDiscount());
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = "";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>();
            Discounts.Add(new Discounts.PointsDiscount());
        }
    }
}