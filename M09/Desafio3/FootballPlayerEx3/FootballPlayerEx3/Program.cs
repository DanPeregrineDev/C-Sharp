using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayerEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Bob", "atacante", "Portugues", 1994, 1.85, 85);

            Console.WriteLine(Player.CalculateAge(player1));
            Console.WriteLine(Player.YearsLeftToRetirement(player1));

            Console.ReadLine();
        }
    }
}
