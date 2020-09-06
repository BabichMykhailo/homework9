using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice34.Task3
{
    class Circle : IFigure
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        private Point Center;
        private double Radius;
        public string GetInfo()
        {
            return $"Radius={Radius}, S={GetSquare()}, Length={GetLength()}";
        }
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetLength()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
