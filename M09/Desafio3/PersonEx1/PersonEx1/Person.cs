using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEx1
{
    internal class Person
    {
        // Properties
        string name;
        string city;

        int age;

        public static void showPerson(Person person)
        {
            Console.WriteLine($"Name: {person.name}\nAge: {person.age}\nCity: {person.city}\n");
        }

        // Constructor
        public Person(string name, string city, int age)
        {
            this.name = name;
            this.city = city;
            this.age = age;
        }
    }
}
