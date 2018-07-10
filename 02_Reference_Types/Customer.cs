using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reference_Types
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string firstName, string email, string phoneNumber)
        {
            FirstName = firstName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string sayHello()
        {
            return $"Hello {FirstName}";
        }
    }
}
