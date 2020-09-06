using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice34.Task3
{
    public class Square : IFigure
    {
        private double Length;

        public string GetInfo()
        {
            return $"Perimeter={GetPerimeter()}, S={GetSquare()}";
        }

        public double GetSquare()
        {
            return Length * Length;
        }
        public double GetPerimeter()
        {
            return Length * 4;
        }
    }
}
