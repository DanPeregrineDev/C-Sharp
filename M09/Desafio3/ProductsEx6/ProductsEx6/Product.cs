using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsEx6
{
    internal class Product
    {
        // Properties
        string name;

        double priceCost;
        double priceSell;
        double profitMargin;
        
        // Gets
        public string GetName() { return name; }
        
        public double GetPriceCost() { return priceCost; }
        public double GetPriceSell() { return priceSell; }

        public double GetProfitMargin()
        {
            profitMargin = priceSell - priceCost;
            
            return profitMargin;
        }
        public double GetProfitMarginPercentage()
        {
            if (GetProfitMargin() != 0)
            {
                return (profitMargin * 100) / priceCost;
            }
            else
            {
                return 0;
            }
        }
        
        // Sets
        public void SetName(string name) { this.name = name; }
        
        public void SetPriceCost(double priceCost) { this.priceCost = priceCost; }
        public void SetPriceSell(double priceSell)
        {
            if (priceSell > priceCost)
            {
                this.priceSell = priceSell;
            }
            else
            {
                Console.WriteLine("O preço de venda não pode ser inferior ao da compra");
            }
        }
        
        // Constructor
        public Product(string name, double priceCost, double priceSell)
        {
            this.name = name;
            this.priceCost = priceCost;
            this.priceSell = priceSell;
        }
    }
}

