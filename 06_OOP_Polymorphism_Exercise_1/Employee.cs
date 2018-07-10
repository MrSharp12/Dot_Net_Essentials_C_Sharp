using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_1
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        protected Employee(string fullName, int iD)
        {
            FullName = fullName;
            ID = iD;
        }
    }
}
