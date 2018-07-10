using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class Developer
    {
        //private decimal _balance;
        
        public string FullName { get; set; }
        public int ID { get; set; }
        public decimal Balance { get; set; } = 100m;
        //public decimal Balance
        //{
        //    get { return _balance; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException();
        //        }
        //        _balance = value;
        //    }
        //} 
        public bool HasPurchasedCourse { get; set; } = false;
        public List<UdemyCourse> ListOfCourses { get; set; } = new List<UdemyCourse>();

        public int GetDevListCount()
        {
            return ListOfCourses.Count();
        }

        public override string ToString()
        {
            return string.Format($", Remaining Balance: {Balance}");
        }
    }
}
