using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет метод для создания экземпляра класса <see cref="Rectangle"/>, полного случайными значениями.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>, полного случайными значениями.
        /// </summary>
        /// <param name="rnd">Экземпляр класса <see cref="Random"/>.</param>
        /// <returns></returns>
        public static Model.Classes.Rectangle Randomize(Random rnd)
        {
            Point2D newCentre = new Point2D(rnd.Next(1, 300), rnd.Next(1, 300));
            return new Model.Classes.Rectangle(RandomDouble.GetRandomDouble(1, 150, rnd), RandomDouble.GetRandomDouble(1, 150, rnd), "Blue", newCentre);
        }
    }
}
