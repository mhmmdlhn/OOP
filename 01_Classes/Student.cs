using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    public class Student
    {
        //fields
        public int No;
        public string Name;
        public string LastName;

        //Property prop :
        public int Age { get; set; }

        //methods
        public void PrintStudentInfo()
        {
            Console.WriteLine($"{No} - Name: {Name}, Last Name: {LastName}, Age: {Age}");
        }
    }
}
