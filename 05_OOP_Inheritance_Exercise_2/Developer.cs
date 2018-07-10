using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public enum LanguageFocusTypes
    {
        Redux,
        Flux,
        AngularJS,
        Angular6,
        NETCore,
        NETFramework

    }
    public abstract class Developer
    {
        // your keyboard feels better than mine... but your trackpad is calabrated to go all sorts of upsidedown..
        public bool HasTakenOrientation { get; set; }
        public int PluralsightID { get; set; }
        public int MonthlyTrainingHours { get; set; }
        public string Language { get; set; }
        public LanguageFocusTypes AreaOfFocus { get; set; }
        //public List<Skills> SkillRatings { get; set; } = new List<Skills>();


        public Developer(bool hasTakenOrientation, int pluralsightID, int monthlyTrainingHours, string language, LanguageFocusTypes areaOfFocus)
        {
            HasTakenOrientation = hasTakenOrientation;
            PluralsightID = pluralsightID;
            MonthlyTrainingHours = monthlyTrainingHours;
            Language = language;
            AreaOfFocus = areaOfFocus;
        }
    }
}
