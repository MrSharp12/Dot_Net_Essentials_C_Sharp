using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Reference_Types;

namespace _02_Reference_Types_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstantiatingCustomerWithConstructor_ShouldSucceed()
        {
            //arrange
            var customer = new Customer("Danzig", "LordofDarkness@gmail.com", "666-666-6666");

            //act
            var actual1 = customer.FirstName;
            var actual2 = customer.Email;
            var actual3 = customer.PhoneNumber;
            var expected1 = "Danzig";
            var expected2 = "LordofDarkness@gmail.com";
            var expected3 = "666-666-6666";

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void CustomerMethod_ShouldSucceed()
        {
            //arrange
            var customer = new Customer("Danzig", "LordofDarkness@gmail.com", "666-666-6666");

            //act
            var actual = customer.sayHello();
            var expected = "Hello Danzig";

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
