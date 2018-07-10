using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_3
{
    public class Sales : Badge
    {
        public decimal SalesOffOfMonthlyGoal { get; set; }
        public string SalesMeeting { get; set; }
        public decimal SalesForTheDay { get; set; }
        public decimal MonthlyGoal { get; set; }

        public override string EnteredBuildingMessage()
        {
            var message = $"Hi!  You are {SalesOffOfMonthlyGoal} dollars from our monthly goal.  Also, remember our monthly goal is {MonthlyGoal} dollars";
            return message;
        }

        public override string EnteredElevatorMessage()
        {
            var message = $"Remember, you have a meeting with {SalesMeeting} today";
            return message;
        }

        public override string LeftFloorMessage()
        {
            var message = $"Great job.  You sold {SalesForTheDay} dollars today.  You are {SalesOffOfMonthlyGoal - SalesForTheDay} dollars away from the monthly goal";
            return message;
        }

        //public override string ToString()
        //{
        //    return string.Format($"Course Name: {Name}, Course Price: {Price}");
        //}
    }
}
