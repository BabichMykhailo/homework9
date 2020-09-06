using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice34.Task3
{
    class Triangle : IFigure
    {
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        private Point A;
        private Point B;
        private Point C;

        private double GetLength(Point point1, Point point2)
        {
            int result = (point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y);
            return Math.Sqrt(result);
        }
        private double GetAB()
        {
            return GetLength(A, B);
        }
        private double GetBC()
        {
            return GetLength(B, C);
        }
        private double GetAC()
        {
            return GetLength(A, C);
        }
        private double GetPerimeter()
        {
            return GetAB() + GetBC() + GetAC();
        }

        public double GetSquare()
        {
            return Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - GetAB()) * (GetPerimeter() / 2 - GetBC()) * (GetPerimeter() / 2 - GetAC()));
        }
        public string GetInfo()
        {
            return $"Perimeter={GetPerimeter()}, S={GetSquare()}";
        }
    }
}
