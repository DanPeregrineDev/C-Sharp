using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
    internal class Vehicle
    {
        // Properties

        string Brand;
        string Model;
        string Color;
        string Plate;

        int YearBuilt;
        int vehicleID;

        Engine Engine;

        static List<Vehicle> VehicleList = new List<Vehicle>();

        public static void createVehicle()
        {
            Console.Clear();

            // Brand

            Console.WriteLine("\nQual o marca do carro?");

            Console.Write("> ");
            string Brand = Console.ReadLine();

            // Model

            Console.WriteLine("\nQual o modelo do carro?");

            Console.Write("> ");
            string Model = Console.ReadLine();

            // Color

            Console.WriteLine("\nQual a cor do carro?");

            Console.Write("> ");
            string Color = Console.ReadLine();

            // Plate

            Console.WriteLine("\nQual a matrícula do carro?");

            Console.Write("> ");
            string Plate = Console.ReadLine();

            // Year built

            Console.WriteLine("\nQual o ano de fabrico do carro?");

            Console.Write("> ");
            int YearBuilt = Convert.ToInt16(Console.ReadLine());

            // Create new Object

            Vehicle newVehicle = new Vehicle();

            newVehicle.Brand = Brand;
            newVehicle.Model = Model;
            newVehicle.Color = Color;
            newVehicle.Plate = Plate;

            newVehicle.YearBuilt = YearBuilt;
            newVehicle.vehicleID = 0;

            newVehicle.Engine = Engine.createEngine();

            // Add the newVehicle to the Vehicle list

            VehicleList.Add(newVehicle);
        }

        public static void showVehicles()
        {
            if (VehicleList.Count < 1) return;

            Console.Clear();

            foreach (var vehicle in VehicleList)
            {
                Engine engine = vehicle.Engine;

                Console.WriteLine($"ID: {vehicle.vehicleID}\nMarca: {vehicle.Brand}\nModelo: {vehicle.Model}\nCor: {vehicle.Color}\nMatrícula: {vehicle.Plate}\nAno de Fabrico: {vehicle.YearBuilt}\n\n");

            }

            Console.WriteLine("ENTER para voltar");
            Console.ReadLine();
        }
    }
}
