using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClass
{

    internal class Program
    {

        static void Main(string[] args)
        {

            // Create Vehicle Object

            Vehicle vehicle1 = new Vehicle();

            vehicle1.Brand = "Opel";
            vehicle1.Model = "Corsa";
            vehicle1.CylinderCapacity = 1200;

            Console.WriteLine("");
            vehicle1.ShowInfo();

            Vehicle vehicle2 = new Vehicle();

            vehicle2.Brand = "Audi";
            vehicle2.Model = "A4";
            vehicle2.CylinderCapacity = 1900;

            Console.WriteLine("");
            vehicle2.ShowInfo();

            Console.ReadKey();
        }

    }

}
