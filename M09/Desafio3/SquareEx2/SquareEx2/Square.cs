using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEx2
{
    internal class Square
    {
        // Properties
        double side;

        // Constructors
        public Square(double side=1)
        {
            if (side <= 20 & side > 0)
            {
                this.side = side;
            }
        }

        public static double Area(Square square)
        {
            return square.side * square.side;
        }

        public static double Diagonal(Square square)
        {
            return Math.Sqrt(2) * square.side;
        }

        public static double Perimiter(Square square)
        {
            return square.side * 4;
        }
    }
}