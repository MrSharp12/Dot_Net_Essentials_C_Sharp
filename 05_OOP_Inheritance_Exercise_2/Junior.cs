using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public abstract class Junior : Developer
    {
        // I like the use of the bool on this one. 
        //public bool HasTakenCodingWithIntent { get; set; }

        //public Junior(bool hasTakenOrientation, int pluralsightID, int monthlyTrainingHours, string language, string areaOfFocus,bool hasTakenCodingWithIntent) : base(hasTakenOrientation, pluralsightID, monthlyTrainingHours, areaOfFocus, language)
        //{
        //    HasTakenCodingWithIntent = hasTakenCodingWithIntent;
        //}
        public Junior(bool hasTakenOrientation, int pluralsightID, int monthlyTrainingHours, string language, LanguageFocusTypes areaOfFocus) : base(hasTakenOrientation, pluralsightID, monthlyTrainingHours, language, areaOfFocus)
        {
        }
    }
}
