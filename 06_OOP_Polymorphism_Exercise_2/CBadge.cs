using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class CBadge : Badge
    {
        protected CBadge(int currentFloor) : base(currentFloor)
        {
        }

        public override string allowLevelAccess(int currentFloor)
        {
            var message = "";
            if (currentFloor == 3)
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
