using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyExemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ben", "35456673", "p201338", DateTime.Today);
            Student student = new Student("Izu", "232434", "s24591", DateTime.Today, 9, "11T");
            Teacher teacher = new Teacher("Miguel", "574844", "t3664", DateTime.Today, 1200, "Master's degree in idk");

            Console.WriteLine("Teacher:");
            Console.WriteLine(teacher.toString());

            Console.ReadLine();
        }
    }
}
