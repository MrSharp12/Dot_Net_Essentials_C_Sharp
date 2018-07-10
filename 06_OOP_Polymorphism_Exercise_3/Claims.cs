using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_3
{
    public class Claims : Badge
    {
        public string ThisMonthHoliday { get; set; }
        public int ClaimsTotal { get; set; }
        public int ClaimsFinishedToday { get; set; }

        public override string EnteredBuildingMessage()
        {
            var message = $"This month's holiday is the {ThisMonthHoliday}";
            return message;
        }

        public override string EnteredElevatorMessage()
        {
            var message = $"You have a {ClaimsTotal} claims left";
            return message;
        }

        public override string LeftFloorMessage()
        {
            var message = $"You have {ClaimsTotal - ClaimsFinishedToday} claims left";
            return message;
        }
    }
}
