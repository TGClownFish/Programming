using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes.Orders
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Order
    {

        /// <summary>
        /// Хранит данные об ID покупателя.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Количество заказов. Статично.
        /// </summary>
        private static int _amountOfOrders = 0;

        /// <summary>
        /// Хранит данные о дате создания.
        /// </summary>
        public DateTime CreateDate { get; }

        /// <summary>
        /// Хранит данные об адрессе покупателя. Объект класса <see cref="Classes.Address"/>.
        /// </summary>
        public Address Address { get; set; }

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
                if (Items.Count == 0 || Items == null)
                {
                    return 0.0;
                }
                else
                {
                    double count = 0;
                    foreach (var i in Items)
                    {
                        count += i.Cost;
                    }
                    return count;
                }
            }
        }
        /// <summary>
        /// Хранит данные о статусе заказа. Является перечислением типа <see cref="OrderStatus"/>.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Хранит размер скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает стоимость заказа с применненой скидкой.
        /// </summary>
        public double Total
        {
            get
            {
                if (Amount == 0)
                {
                    return 0;
                }
                else
                {
                    return Amount - Total;
                }
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Хранит данные об адрессе покупателя. Объект класса <see cref="Classes.Address"/>.</param>
        /// <param name="items">Хранит список объектов класса <see cref="Item"/>.</param>
        public Order(Address address, List<Item> items)
        {
            Id = _amountOfOrders;
            _amountOfOrders++;
            CreateDate = DateTime.Now;
            Address = address;
            Items = items;
            Status = 0;
            DiscountAmount = 0;
        }

        /// <summary>
        /// Создаёт пустой объект класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Id = _amountOfOrders;
            _amountOfOrders++;
            CreateDate = DateTime.Now;
            Address = new Address();
            Items = new List<Item>();
            Status = 0;
            DiscountAmount = 0;
        }
    }
}
