using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
    internal class Program
    {
        public static int Menu(List<string> options)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("  Gestor de Veículos  ");
            Console.WriteLine("----------------------\n");

            foreach (var option in options)
            {
                Console.WriteLine($"{option}");
            }

            Console.Write("> ");
            int selection = Convert.ToInt16(Console.ReadLine());

            return selection;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                List<string> options = new List<string> { "1 - Criar Veículo", "2 - Listar Veículos", "3 - Sair\n" };
                int selection = Menu(options);

                if (selection > 0 && selection < 7) 
                {
                    switch (selection)
                    {
                        case 1:
                            Vehicle.createVehicle();
                            break;
                        case 2:
                            Vehicle.showVehicles();
                            break;
                        case 3:
                            return;
                    }
                }
            }
            
        }
    }
}
