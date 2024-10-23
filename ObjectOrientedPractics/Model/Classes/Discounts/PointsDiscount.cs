using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes.Discounts
{
    /// <summary>
    /// Хранит данные и методы, связанные с накопительной скидкой.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество баллов.
        /// </summary>
        private int _points;
        /// <summary>
        /// Хранит количество баллов.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Значение в поле {nameof(Points)} не должно быть ниже нуля.");
                }
                else
                {
                    _points = value;
                }
            }
        }

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
        public double Calculate(List<Item> items)
        {
            double fullCost = 0;
            for (int i = 0; i < items.Count; i++)
            {
                fullCost += items[i].Cost;
            }
            if (Points == 0 || fullCost ==0)
            {
                return 0;
            }
            double percentage = Points / fullCost;
            if (percentage >= 0.3)
            {
                return Math.Ceiling( fullCost * 0.3);
            }
            else
            {
                return Math.Ceiling(fullCost * percentage);
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
            Points -= Convert.ToInt32(discount);
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
        public PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PointsDiscount"./>
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }
    }
}
