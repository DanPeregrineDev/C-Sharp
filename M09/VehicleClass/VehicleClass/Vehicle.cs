using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClass
{

    internal class Vehicle
    {
        // Caracteristics
        public string Brand;
        public string Model;
        public string Color;
        public string Plate;

        public int Year_Assembled;
        public int HorsePower;
        public int CylinderCapacity;
        public int NumberOfDoors;
        
        // Behavior
        public float CalculateVelocity(float Distance, float Time)
        {
            return (Distance / Time);
        }

        public void ShowInfo()
        {
            Console.WriteLine("The vehicle " + Brand + " " +  Model + " " + "has " + CylinderCapacity + " Cylinder Capacity");
        }

    }

}
