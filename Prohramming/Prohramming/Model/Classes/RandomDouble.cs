using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Предосталяет метод для создания случайного значения double в указанных пределах.
    /// </summary>
    static public class RandomDouble
    {
        /// <summary>
        /// Выдаёт случайное значение double в указанных пределах.
        /// </summary>
        /// <param name="minimum">Минимальное значение.</param>
        /// <param name="maximum">Максимальное значение.</param>
        /// <param name="random">Объект класса <see cref="Random"/></param>
        /// <returns></returns>
        static public double GetRandomDouble(double minimum, double maximum, Random random)
        {
            return Math.Round((random.NextDouble() * (maximum - minimum) + minimum), 2);
        }
    }
}
