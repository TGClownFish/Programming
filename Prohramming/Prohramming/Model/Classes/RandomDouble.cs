using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    static public class RandomDouble
    {
        static public double GetRandomDouble(double minimum, double maximum, Random random)
        {
            return Math.Round((random.NextDouble() * (maximum - minimum) + minimum), 2);
        }
    }
}
