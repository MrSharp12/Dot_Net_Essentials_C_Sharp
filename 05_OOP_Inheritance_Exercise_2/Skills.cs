using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class Skills
    {
        public string Name { get; set; }
        public int Rating { get; set; }

        public Skills(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }
    }
}
