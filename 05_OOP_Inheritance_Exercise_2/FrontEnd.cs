using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class FrontEnd : Junior
    {
        // how are you planning on handeling the inheritance of senior, nameing class of front end will make it hard to determine any difference in the future. 
        //public bool HasTakenOOPCourse { get; set; }
        //public List<Skills> SkillRatings { get; set; } = new List<Skills>();

        //public FrontEnd(bool hasTakenOrientation, int pluralsightID, int monthlyTrainingHours, string language, LanguageFocusTypes areaOfFocus, bool hasTakenCodingWithIntent, bool hasTakenOOPCourse) : base(hasTakenOrientation, pluralsightID, monthlyTrainingHours, language,  hasTakenCodingWithIntent)
        //{
        //    HasTakenOOPCourse = hasTakenOOPCourse;
        //}

        //public int GetListCount() //this method name is vague and on its nose its hard to know what "list" your refering to. 
        //{
        //    return SkillRatings.Count();
        //}
        public FrontEnd(bool hasTakenOrientation, int pluralsightID, int monthlyTrainingHours, string language, LanguageFocusTypes areaOfFocus) : base(hasTakenOrientation, pluralsightID, monthlyTrainingHours, language, areaOfFocus)
        {
        }
    }
}
