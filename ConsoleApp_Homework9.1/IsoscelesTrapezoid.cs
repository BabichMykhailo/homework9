using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practise1
{
    public class IsoscelesTrapezoid
    {
        public Point UppLeft { get; set; }

        public Point UppRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public IsoscelesTrapezoid(Point uppLeft, Point uppRight, Point bottomLeft, Point bottomRight)
        {
            UppLeft = uppLeft;
            UppRight = uppRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;
        }

        public double GetLength(Point point1, Point point2)
        {
            int result = (point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y);
            return Math.Sqrt(result);
        }

        public double GetA()
        {
            return GetLength(UppLeft, UppRight);
        }
        public double GetB()
        {
            return GetLength(BottomLeft, BottomRight);
        }
        public double GetC()
        {
            return GetLength(UppLeft, BottomLeft);
        }
        public bool IsIsoscelesTrapezoid()
        {
            if(UppLeft == UppRight && BottomRight == BottomLeft)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PerimeterIsoscelesTrapezoid()
        {
            return GetA() + GetB() + GetC() + GetC();
        }

        public double SquareIsoscelesTrapezoid()
        {
            return ((GetA() + GetB()) / 2) * Math.Sqrt(GetC() * GetC() - ((GetA() - GetB()) / 2) * ((GetA() - GetB()) / 2));
        }
    }

     
}
