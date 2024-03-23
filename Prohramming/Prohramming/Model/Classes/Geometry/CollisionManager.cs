using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < (Math.Abs(rectangle1.Width + rectangle2.Width) / 2))
                if (Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < (Math.Abs(rectangle1.Length + rectangle2.Length) / 2))
                    return true;
            return false;
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        { 
            double TriangleLeg1 = Math.Pow(ring1.Center.X - ring2.Center.X, 2);
            double TriangleLeg2 = Math.Pow(ring1.Center.Y - ring2.Center.Y, 2);
            double TriangleHypotenuse = Math.Pow(TriangleLeg1 + TriangleLeg2, 0.5);
            if (TriangleHypotenuse < (ring1.OuterRadius + ring2.OuterRadius))
                return true;
            return false;
        }
    }
}
