using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Player.initializePlayer("Cristiano Ronaldo", true, 129, 5);
            
            Console.WriteLine(Player.getPlayer());

            Adversary adversary1 = new Adversary("Ben", "Manchester");
            Adversary adversary2 = new Adversary("Wilson", "Manchester");
            Adversary adversary3 = new Adversary("Miguel", "Arsenal");
            
            Console.WriteLine(Adversary.getInfo(adversary1));

            Adversary.alerted = true;

            Console.WriteLine(Adversary.getInfo(adversary2));
            Console.WriteLine(Adversary.getInfo(adversary3));
            
            Console.ReadKey();
        }
    }
}