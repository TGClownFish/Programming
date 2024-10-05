using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные о корзине покупателя.
    /// </summary>
    public class Cart
    {
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
        /// Создаёт пустой экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }
    }
}
