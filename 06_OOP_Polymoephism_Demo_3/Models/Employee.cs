using _06_OOP_Polymoephism_Demo_3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymoephism_Demo_3.Models
{
    public class Employee
    {
        private ISwipeable _swipeable;

        public Employee(ISwipeable swipeable)//set up for dependency injection
        {
            _swipeable = swipeable;
        }

        public void SwipeCard()
        {
            Console.WriteLine("Swiping card now");
            _swipeable.Swipe();
        }

    }
}
