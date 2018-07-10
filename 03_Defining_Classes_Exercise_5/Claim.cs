using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_5
{
    public class Claim
    {
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public decimal ClaimCost { get; set; }
        public TimeSpan ClaimCheck => DateOfIncident - DateOfClaim;

        public Claim()
        {
        }

        public Claim(DateTime dateOfIncident, DateTime dateOfClaim, decimal claimCost)
        {
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            ClaimCost = claimCost;
        }
    }
}
