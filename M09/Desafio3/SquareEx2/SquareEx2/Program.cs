using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(8);

            Console.WriteLine(Square.Area(square1));
            Console.WriteLine(Square.Diagonal(square1));
            Console.WriteLine(Square.Perimiter(square1));

            Console.ReadLine();
        }
    }
}
