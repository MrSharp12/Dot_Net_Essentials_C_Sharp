using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_3
{
    public class Coder : Badge
    {
        public string NewLanguage { get; set; }
        public int StandupMeeting { get; set; }
        public int LinesOfCode { get; set; }

        public override string EnteredBuildingMessage()
        {
            var message = $"A new language, {NewLanguage}, just came out today.  Give it a look!";
            return message;
        }

        public override string EnteredElevatorMessage()
        {
            var message = $"You have a standup in {StandupMeeting} minutes";
            return message;
        }

        public override string LeftFloorMessage()
        {
            var message = $"You pushed {LinesOfCode} lines of code";
            return message;
        }
    }
}
