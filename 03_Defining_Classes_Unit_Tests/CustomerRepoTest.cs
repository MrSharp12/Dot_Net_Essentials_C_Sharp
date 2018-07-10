using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_3;

namespace _03_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class CustomerRepoTest
    {

        private Customer _customer;
        private CustomerRepository _customerRepository;

        [TestInitialize]
        public void Arrange()
        {
            _customer = new Customer(1, "Danzig", 54, 40);
            _customerRepository = new CustomerRepository();
        }

        [TestMethod]
        public void CustomerEmail_ReturnString()
        {
            
            //act
            var actual = _customerRepository.EmailCustomer(_customer);
            var expected = "You're a beast.";

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
