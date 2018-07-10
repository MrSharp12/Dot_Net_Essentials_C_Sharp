using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class ABadge : Badge
    {
        protected ABadge(int currentFloor) : base(currentFloor)
        {
        }

        public override string allowLevelAccess(int currentFloor)
        {
            var message = "";
            if (currentFloor == 1)
            {
                message = "Access Allowed";
            }
            else
            {
                message = "Access Denied";
            }
            return message;
        }
    }
}
