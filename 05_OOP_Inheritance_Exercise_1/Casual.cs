using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    public abstract class Casual : Outing, IEmotions
    {
        public void CheckHappiness()
        {
            throw new NotImplementedException();
        }
    }
}
