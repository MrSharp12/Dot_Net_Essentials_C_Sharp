using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class BBadge : Badge
    {
        protected BBadge(int currentFloor) : base(currentFloor)
        {
        }

        public override string allowLevelAccess(int currentFloor)
        {
            var message = "";
            if (currentFloor == 2)
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
