using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    public class Concert : Casual, IEmotions
    {
        public override void CalculateCostPerPerson()
        {
            throw new NotImplementedException();
        }

        public new void CheckHappiness()
        {
            throw new NotImplementedException();
        }
    }
}
