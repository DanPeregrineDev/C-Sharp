using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorEx5
{
    internal class Program
    {
        private static Elevator elevator = new Elevator(20, 6);
        
        public static int Menu()
        {
            Console.Clear();
            
            Console.WriteLine($"Total floors: {elevator.GetTotalFloors()}");
            Console.WriteLine($"Current Floor: {elevator.GetCurrentFloor()}");
            Console.WriteLine($"Max capacity: {elevator.GetMaxCapacity()}");
            Console.WriteLine($"Current inside: {elevator.GetCurrentPeopleInside()}");

            Console.WriteLine("\n1 - Add a person");
            Console.WriteLine("2 - Remove a person");
            Console.WriteLine("3 - Increase floor");
            Console.WriteLine("4 - Decrease floor");

            Console.Write("\n> ");
            int selection = Convert.ToInt16(Console.ReadLine());
            
            return selection;
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                int selection = Menu();

                switch (selection)
                {
                    case 1:
                        elevator.AddPerson(elevator);

                        break;

                    case 2:
                        elevator.RemovePerson(elevator);

                        break;

                    case 3:
                        elevator.IncreaseFloor(elevator);

                        break;

                    case 4:
                        elevator.DecreaseFloor(elevator);
                        
                        break;
                }
            }
        }
    }
}

