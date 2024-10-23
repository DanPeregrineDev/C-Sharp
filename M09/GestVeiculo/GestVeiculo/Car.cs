using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
    internal class Car:Vehicle
    {
        // Properties
        private string brand;
        private string model;
        private string fuelType;

        private int maxLiters;
        
        private double avarageConsumption;
        
        // Gets
        public string GetBrand() { return brand; }
        public string GetModel() { return model; }
        public string GetFuelType() { return fuelType; }
        public int GetMaxLiters() { return maxLiters; }
        public double GetAvarageConsumption() { return avarageConsumption; }
        
        // Constructor
        public Car(string plate, int year, Owner owner, string brand, string model, string fuelType, int maxLiters, double avarageConsumption) : base(plate, year, owner)
        {
            this.brand = brand;
            this.model = model;
            this.fuelType = fuelType;
            this.maxLiters = maxLiters;
            this.avarageConsumption = avarageConsumption;
        }
        
        // Methods
        public double MaxRange(Car car)
        {
            double range = maxLiters * avarageConsumption;
            
            return range;
        }

        public double FullRangeCost(Car car)
        {
            if (car.fuelType.ToLower() == "gasolina 98")
            {
                double cost = maxLiters * 1.954;
                
                return cost;
            }

            if (car.fuelType.ToLower() == "gasoleo")
            {
                double cost = maxLiters * 1.704;

                return cost;
            }

            if (car.fuelType.ToLower() == "gpl")
            {
                double cost = maxLiters * 0.924;

                return cost;
            }
            
            return 0;
        }
    }
}