using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person newPerson1 = new Person("Ben", "Albany", 32);
            Person newPerson2 = new Person("John", "Atlanta", 21);

            Person.showPerson(newPerson1);
            Person.showPerson(newPerson2);

            Console.ReadLine();
        }
    }
}
