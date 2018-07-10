using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_5
{
    class ClaimRepository
    {

        public string ClaimValidityCheck(Claim claim)
        {
            var message = "We will review your claim.";
            if (claim.ClaimCheck.Days > 30)
            {
                message = "Your claim is 30 days overdue and cannot be processed.";
            }
            return message;
        }

        public string onlineClaimCheck(Claim claim)
        {
            var message = "";
            if (claim.ClaimCost > 10000)
            {
                message =  "Please call 1-800-345-6789 to speak to a representative.";
            }
            return message;
        }
    }
}
