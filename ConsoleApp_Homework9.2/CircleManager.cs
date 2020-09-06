using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice34
{
    class CircleManager
    {
        public static string CreateCircles()
        {
            Circle c1 = new Circle(new Point() { X = 0, Y = 0 }, 12 );
            Circle c2 = new Circle(new Point() { X = 3, Y = 5 }, 11); 
            if (c1.IsEqual(c2))
            {
                return "Squares are equal";
            }
            return "Are different";
        }
    }
}
