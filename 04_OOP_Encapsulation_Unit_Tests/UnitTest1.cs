using System;
using _04_OOP_Encapsulation_Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_OOP_Encapsulation_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameIsValid_ShouldSucceed()
        {
            //arrange
            var danzig = new Customer();
            danzig.FirstName = "Glenn";

            //act
            var expected = "Glenn";
            var actual = danzig.FirstName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "You must enter a first name.")]
        public void FirstNameIsNotValid_ShouldSucceed()
        {
            //arrange
            var danzig = new Customer();
            danzig.FirstName = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Not a valid age.")]
        public void AgeIsNotValid_ShouldSucceed()
        {
            //arrange
            var danzig = new Customer();
            danzig.Age = 666;
        }

        [TestMethod]
        public void LastNameIsValid_ShouldSucceed()
        {
            //arrange
            var danzig = new Customer();
            danzig.LastName = "Danzig";

            //act
            var expected = "Danzig";
            var actual = danzig.LastName;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
