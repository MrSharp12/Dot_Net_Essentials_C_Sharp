using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_1
{
    public class Employee
    {
        public int IdNumber { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsOfEmployment { get; set; }

        public Employee(int idNumber, string lastName, int age, int yearsOfEmployment)
        {
            IdNumber = idNumber;
            LastName = lastName;
            Age = age;
            YearsOfEmployment = yearsOfEmployment;
        }
    }
}
