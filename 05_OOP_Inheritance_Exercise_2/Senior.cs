using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public abstract class Senior : Developer
    {
        public Senior(bool hasTakenOrientation, int pluralsightID, int monthlyTrainingHours, string Language, LanguageFocusTypes areaOfFocus) : base(hasTakenOrientation, pluralsightID, monthlyTrainingHours, Language, areaOfFocus)
        {
        }
    }
}
