using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// ID покупателя.
        /// </summary>
        private int _id;
        /// <summary>
        /// Хранит данные об ID покупателя.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Количество заказов. Статично.
        /// </summary>
        private static int _amountOfOrders = 0;

        /// <summary>
        /// Дата создания.
        /// </summary>
        private DateTime _createDate;
        /// <summary>
        /// Хранит данные о дате создания.
        /// </summary>
        public DateTime CreateDate { get;}

        /// <summary>
        /// Адресс покупателя.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Хранит данные об адрессе покупателя. Объект класса <see cref="Classes.Address"/>.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Хранит список объектов класса <see cref="Item"/>.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Выводит стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items.Count == 0 || _items == null)
                {
                    return 0.0;
                }
                else
                {
                    double count = 0;
                    foreach (var i in _items)
                    {
                        count += i.Cost;
                    }
                    return count;
                }
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Хранит данные об адрессе покупателя. Объект класса <see cref="Classes.Address"/>.</param>
        /// <param name="items">Хранит список объектов класса <see cref="Item"/>.</param>
        public Order (Address address, List<Item> items)
        {
            Id = _amountOfOrders;
            _amountOfOrders++;
            CreateDate = DateTime.Today;
            Address = address;
            Items = items;
        }

        /// <summary>
        /// Создаёт пустой объект класса <see cref="Order"/>.
        /// </summary>
        public Order ()
        {
            _id = _amountOfOrders;
            _amountOfOrders++;
            CreateDate= DateTime.Today;
            Address = new Address();
            Items = new List<Item>();
        }
    }
}
