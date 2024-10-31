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
    public class Cart : ICloneable, IEquatable<Cart>
    {

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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// Копирует экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public object Clone()
        {
            return new Cart(this.Items);
        }

        /// <summary>
        /// Проверяет, схож ли оригианальный объект с входящим. Перегрузка стандартного метода Equals.
        /// </summary>
        /// <param name="other">Проверяемый объект.</param>
        /// <returns>true, если объекты схожи, иначе - false.</returns>
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if ((other is not Cart))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            var otherItem = (Cart)other;
            return (this.Items == otherItem.Items);
        }

        /// <summary>
        /// Проверяет, схож ли оригианальный объект с входящим. Реализация стандартного интерфейса IEquatable<T>.
        /// </summary>
        /// <param name="other">Проверяемый объект.</param>
        /// <returns>true, если объекты схожи, иначе - false.</returns>
        public bool Equals(Cart other)
        {
            if (other == null)
                return false;
            if (this.Items == other.Items)
                return true;
            else
                return false;
        }
    }
}
