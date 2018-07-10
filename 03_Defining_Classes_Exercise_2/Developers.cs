using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_2
{
    public class Developers
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public bool HasPluralsight { get; set; }

        public Developers(int id, string lastName, bool hasPluralsight)
        {
            Id = id;
            LastName = lastName;
            HasPluralsight = hasPluralsight;
        }
    }
}
