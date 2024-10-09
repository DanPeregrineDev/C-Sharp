using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyExemple
{
    internal class Person
    {
        // Properties
        string name;
        string idnumber;
        string processnumber;

        DateTime birthdate;

        // Gets
        public string GetName() { return name; }
        public string GetIDNumber() { return idnumber; }
        public string GetProcessNumber() { return processnumber; }
        public DateTime GetBirthdate() {  return birthdate; }

        // Sets
        public void SetName(string name) { this.name = name; }
        public void SetIDNumber(string idnumber) { this.idnumber = idnumber; }
        public void SetProcessNumber(string processnumber) { this.processnumber = processnumber; }
        public void SetBirthdate(DateTime birthdate) { this.birthdate = birthdate; }

        // Constructor
        public Person(string name, string idnumber, string processnumber, DateTime birthdate)
        {
            this.name = name;
            this.idnumber = idnumber;
            this.processnumber = processnumber;
            this.birthdate = birthdate;
        }

        public virtual string toString()
        {
            return $"Name: {name}\nID: {idnumber}\nProcessNumber: {processnumber}\nBirthdate: {birthdate}";
        }
    }
}
