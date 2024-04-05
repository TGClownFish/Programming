using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes.Geometry
{
    public static class RectangleFactory
    {
        public static Model.Classes.Rectangle Randomize(Random rnd)
        {
            Point2D newCentre = new Point2D(rnd.Next(1, 300), rnd.Next(1, 300));
            return new Model.Classes.Rectangle(GetRandomDouble(1, 150, rnd), GetRandomDouble(1, 150, rnd), "Blue", newCentre);
        }
        public static double GetRandomDouble(double minimum, double maximum, Random random)
        {
            return Math.Round((random.NextDouble() * (maximum - minimum) + minimum), 2);
        }
    }
}
