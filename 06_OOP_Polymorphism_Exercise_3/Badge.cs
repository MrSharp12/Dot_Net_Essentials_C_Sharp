using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_3
{
    public abstract class Badge
    {
        public abstract string EnteredBuildingMessage();
        public abstract string EnteredElevatorMessage();
        public abstract string LeftFloorMessage();

    }
}
