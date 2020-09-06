using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IsoscelesTrapezoid> trapezoids = new List<IsoscelesTrapezoid>();

            Point p1 = new Point() { X = -3, Y = 3 };
            Point p2 = new Point() { X = 3, Y = 3 };
            Point p3 = new Point() { X = -5, Y = 0 };
            Point p4 = new Point() { X = 5, Y = 0 };
            trapezoids.Add(new IsoscelesTrapezoid(p1, p2, p3, p4));

            p1 = new Point() { X = -2, Y = 2 };
            p2 = new Point() { X = 4, Y = 4 };
            p3 = new Point() { X = -6, Y = 0 };
            p4 = new Point() { X = 6, Y = 0 };
            trapezoids.Add(new IsoscelesTrapezoid(p1, p2, p3, p4));

            p1 = new Point() { X = -8, Y = 8 };
            p2 = new Point() { X = 2, Y = 2 };
            p3 = new Point() { X = -3, Y = 0 };
            p4 = new Point() { X = 3, Y = 0 };
            trapezoids.Add(new IsoscelesTrapezoid(p1, p2, p3, p4));

            p1 = new Point() { X = -2, Y = 2 };
            p2 = new Point() { X = 2, Y = 2 };
            p3 = new Point() { X = -3, Y = 0 };
            p4 = new Point() { X = 3, Y = 0 };
            trapezoids.Add(new IsoscelesTrapezoid(p1, p2, p3, p4));

            double avgSum = 0;
            foreach (var L in trapezoids)
            {
                avgSum += L.SquareIsoscelesTrapezoid();
            }
            avgSum /= 4;
            int c = 0;
            foreach (var L in trapezoids)
            {
                if (L.SquareIsoscelesTrapezoid() > avgSum)
                {
                    c += 1;
                }
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
