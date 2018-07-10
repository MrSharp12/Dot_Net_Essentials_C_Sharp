using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    public abstract class Outing
    {
        public decimal TotalCost { get; set; }
        public DateTime OutingDate { get; set; }
        public string Location { get; set; }
        public int NumberAttended { get; set; }

        public Outing()
        {

        }

        public Outing(decimal totalCost, DateTime outingDate, string location, int numberAttended)
        {
            TotalCost = totalCost;
            OutingDate = outingDate;
            Location = location;
            NumberAttended = numberAttended;
        }

        public abstract void CalculateCostPerPerson();
    }
}
