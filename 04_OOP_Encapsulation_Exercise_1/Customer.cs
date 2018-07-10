using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_1
{
    public class Customer
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You must enter a first name.");
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You must enter a last name.");
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Not a valid age.");
                }
                _age = value;
            }
        }
        //public Customer(string LastName)
        //{
        //    LastName = LastName;
        //}
    }
}
