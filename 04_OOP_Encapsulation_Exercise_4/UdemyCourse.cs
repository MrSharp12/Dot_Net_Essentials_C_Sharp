using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class UdemyCourse
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public UdemyCourse(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format($"Course Name: {Name}, Course Price: {Price}");
        }
    }
}
