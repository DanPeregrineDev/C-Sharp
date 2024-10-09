using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
    public class Engine
    {
        string HorsePower;
        string FuelType;

        public static Engine createEngine()
        {
            Console.Clear();

            // HorsePower

            Console.WriteLine("\nQuantos cavalos tem o motor?");

            Console.Write("> ");
            string HorsePower = Console.ReadLine();

            // FuelType

            Console.WriteLine("\nQual o tipo de gasolina?");

            Console.Write("> ");
            string FuelType = Console.ReadLine();

            // Create new Engine Object

            Engine newEngine = new Engine();

            newEngine.HorsePower = HorsePower;
            newEngine.FuelType = FuelType;

            return newEngine;
        }
    }
}
