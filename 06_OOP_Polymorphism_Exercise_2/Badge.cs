using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public abstract class Badge
    {
        public int CurrentFloor { get; set; }

        protected Badge(int currentFloor)
        {
            CurrentFloor = currentFloor;
        }

        public abstract string allowLevelAccess(int currentFloor);

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            var badge = obj as Badge;
            return badge != null && Equals(badge);
        }

        protected bool Equals(Badge badge)
            => CurrentFloor.Equals(badge.CurrentFloor);
    }
}