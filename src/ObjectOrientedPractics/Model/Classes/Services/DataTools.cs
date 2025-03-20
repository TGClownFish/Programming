using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes.Services
{
    /// <summary>
    /// Хранит условие, по которой проходит сортировка.
    /// </summary>
    /// <param name="item">Проверяемый товар.</param>
    public delegate bool FilterType(Item item);

    /// <summary>
    /// Хранит методы для сортировок и фильтраций.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрация по цене.
        /// </summary>
        /// <param name="item">Проверяемый товар.</param>
        /// <returns>true, если цена товара > 5000, иначе false.</returns>
        public static bool ByCost (Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Фильтрация по категории.
        /// </summary>
        /// <param name="item">Проверяемый товар.</param>
        /// <returns>true, если категория товара равна <see cref="Category.Toys"/>, иначе false.</returns>
        public static bool ByCategory(Item item)
        {
            return item.Category == Category.Toys;
        }

        /// <summary>
        /// Фильтрует товары.
        /// </summary>
        /// <param name="items">Фильруемый список товаров.</param>
        /// <param name="filterType">Условие, по которой проходит сортировка.</param>
        /// <returns>Отфильтрованный список товаров.</returns>
        public static List<Item> Filter(List<Item> items, FilterType filterType)
        {
            List<Item> filtered = new List<Item>();
            foreach (Item item in items)
            {
                if (filterType(item))
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }

    }
}
