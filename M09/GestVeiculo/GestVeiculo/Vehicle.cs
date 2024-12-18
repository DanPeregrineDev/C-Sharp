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
        private string plate;

        private int year;

        private Owner owner;
        
        // Gets
        public string GetPlate() { return plate; }
        public int GetYear() { return year; }
        public Owner GetOwner() { return owner; }
        
        // Constructor
        public Vehicle(string plate, int year, Owner owner)
        {
            this.plate = plate;
            this.year = year;
            this.owner = owner;
        }
    }
}