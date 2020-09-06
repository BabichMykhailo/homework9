using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice34
{
    public class Circle
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
        public Point Center { get; set; }
        public double Radius { get; set; }

        private double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
        public bool IsEqual(Circle circle)
        {
            return this.GetSquare() == circle.GetSquare();
        }
    }
}
