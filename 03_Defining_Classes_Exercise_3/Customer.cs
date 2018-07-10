using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_3
{
    public class Customer
    {
        public int KomodoID { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsWithKomodo { get; set; }

        public Customer(int komodoID, string lastName, int age, int yearsWithKomodo)
        {
            KomodoID = komodoID;
            LastName = lastName;
            Age = age;
            YearsWithKomodo = yearsWithKomodo;
        }
    }
}
