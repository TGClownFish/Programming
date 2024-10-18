using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные и методы, связанные с накопительной скидкой.
    /// </summary>
    public class PointsDiscount
    {
        /// <summary>
        /// Хранит количество баллов.
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Выводит информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {Points} баллов";
            }
        }

        /// <summary>
        /// Вычисляет размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки (не может быть выше 0.3).</returns>
        public double Calculate (List<Item> items)
        {
            double fullCost = 0;
            for (int i = 0;i<items.Count; i++)
            {
                fullCost += items[i].Cost;
            }
            double percentage = fullCost / Points;
            if (percentage >= 0.3)
            {
                return 0.3;
            }
            else
            {
                return percentage;
            }
        }

        /// <summary>
        /// Списывает необходимое количество баллов и возвращает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки (не может быть выше 0.3).</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= Convert.ToInt32(Points * discount);
            return discount;
        }

        /// <summary>
        /// Добавляет баллы на основе стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double fullCost = 0;
            for (int i = 0; i < items.Count; i++)
            {
                fullCost += items[i].Cost;

                Points += Convert.ToInt32(Math.Ceiling(fullCost * 0.1));
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="PointsDiscount"./>
        /// </summary>
        /// <param name="points">Количество баллов.</param>
        PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PointsDiscount"./>
        /// </summary>
        PointsDiscount()
        {
            Points = 0;
        }
    }
}
