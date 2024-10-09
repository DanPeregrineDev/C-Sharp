using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager
{
    internal class Student
    {
        // Properties

        public string studentName;
        public string studentClass;

        public int studentAge;
        public int studentID;
        public int studentProcessNumber;

        // Functions

        public Student(string _studentName, int _studentAge)
        {
            studentName = _studentName;
            studentAge = _studentAge;
        }
    }
}
