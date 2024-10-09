using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyExemple
{
    internal class Teacher:Person
    {
        // Properties
        float salary;
        
        string degree;

        // Gets
        public float GetSalary(float salary) { return salary; }
        public string GetDegree(string degree) { return degree; }

        // Sets
        public void SetSalary(float salary) { this.salary = salary; }
        public void SetDegree(string degree) {  this.degree = degree; }

        // Constructor
        public Teacher(string name, string idnumber, string processnumber, DateTime birthdate, float salary, string degree) : base(name, idnumber, processnumber, birthdate)
        {
            this.salary = salary;
            this.degree = degree;
        }

        public override string toString()
        {
            return $"Salary: {salary}\nDegree: {degree}";
        }
    }
}
