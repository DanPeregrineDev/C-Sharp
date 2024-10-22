using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.WriteLine("Nome do produto:");
            
            Console.Write("\n> ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Proço de custo:");
            
            Console.Write("\n> ");
            double priceCost = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Proço de venda:");
            
            Console.Write("\n> ");
            double priceSell = Convert.ToDouble(Console.ReadLine());

            Product product = new Product(name, priceCost, priceSell);
            
            // Prints
            Console.WriteLine($"Preço de custo: {product.GetPriceCost()}");
            Console.WriteLine($"Preço de venda: {product.GetPriceSell()}");
            Console.WriteLine($"Margem de lucro em percentagem: {product.GetProfitMarginPercentage()}");
            
            
            Console.ReadLine();
        }
    }
}