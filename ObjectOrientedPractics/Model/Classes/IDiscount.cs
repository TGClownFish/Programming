using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public interface IDiscount
    {
        /// <summary>
        /// Выводит информацию о скидке.
        /// </summary>
        string Info {  get; }

        /// <summary>
        /// Вычисляет размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Обнвляет данные и выводит размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.></param>
        /// <returns>Размер скидки</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обнвляет данные.
        /// </summary>
        /// <param name="items">писок товаров.</param>
        void Update(List<Item> items);
    }
}
