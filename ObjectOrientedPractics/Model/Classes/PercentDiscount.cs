using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные и методы, связанные с процентной скидкой.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Хранит категорию товара, к которой вычисляется скидка.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Процент скидки.
        /// </summary>
        private int _percent;
        /// <summary>
        /// Хранит процент скидки.
        /// </summary>
        public int Percent 
        { 
            get 
            { 
                return _percent; 
            } 
            set 
            { 
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException($"Значение в поле {nameof(Percent)} не должно быть " +
                        $"ниже 1 или выше 10 (Категория: {Category}).");
                }
                _percent = value; 
            } 
        }

        /// <summary>
        /// Сумма, потраченная на категорию товара.
        /// </summary>
        private double _amountSpent;
        /// <summary>
        /// Хранит сумму, потраченную на категорию товара.
        /// </summary>
        public double AmountSpent
        {
            get
            {
                return _amountSpent;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Значение в поле {nameof(AmountSpent)} не должно быть ниже 0.");
                }
                _amountSpent = value;
            }
        }

        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {Percent}%";
            }
        }

        /// <summary>
        /// Вычисляет размер скидки для категории товара.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает процент скидки скидки (не может быть выше 10).</returns>
        public double Calculate(List<Item> items)
        {
            double spent = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    spent += items[i].Cost;
                }
            }
            if (spent > 0)
            {
                return Convert.ToInt32(spent / 1000);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Добавляет необходимое количество процентов и возвращает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки (не может быть выше 10).</returns>
        public double Apply(List<Item> items)
        {
            Update(items);
            // if AmountSpent == 10000 than (AmountSpent / 1000) + 1 == 11
            if (AmountSpent < 10000)
            {
                Percent = Convert.ToInt32(Math.Floor(AmountSpent / 1000.0) + 1);
            }
            return Calculate(items);
        }

        /// <summary>
        /// Добавляет необходимое количество к сумме потраченных товаров.

        /// <param name="items">Список товаров.</param>
        /// </summary>
        public void Update(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    AmountSpent += items[i].Cost;   
                }
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория товара, к которой вычисляется скидка.</param>
        public PercentDiscount (Category category)
        {
            Category = category;
            Percent = 1;
            AmountSpent = 0;
        }
    }
}
