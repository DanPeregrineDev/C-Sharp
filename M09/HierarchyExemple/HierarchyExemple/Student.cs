using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyExemple
{
    internal class Student:Person
    {
        // Properties
        int number;

        string grade;

        // Gets
        public int GetNumber(int number) { return number; }
        public string GetGrade(string grade) { return grade; }

        // Sets
        public void SetNumber(int number) { this.number = number; }
        public void SetGrade(string grade) { this.grade = grade; }

        // Constructor
        public Student(string name, string idnumber, string processnumber, DateTime birthdate, int number, string grade):base(name, idnumber, processnumber, birthdate)
        {
            this.number = number;
            this.grade = grade;

        }

        public override string toString()
        {
            return $"Class: {grade}\nNumber: {number}";
        }
    }
}
