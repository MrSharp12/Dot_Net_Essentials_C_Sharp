using System;
using _04_OOP_Encapsulation_Exercise_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_OOP_Encapsulation_Unit_Tests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void DetermineMonthlyRateByAge16_19_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(17);

            //act
            var expected = 228m;
            var actual = newDriver.DetermineMonthlyRateByAge();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DetermineMonthlyRateByAge20_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(20);

            //act
            var expected = 192m;
            var actual = newDriver.DetermineMonthlyRateByAge();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DetermineMonthlyRateByAge20_22_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(21);

            //act
            var expected = 192m;
            var actual = newDriver.DetermineMonthlyRateByAge();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DetermineMonthlyRateByAge23_25_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(23);

            //act
            var expected = 180m;
            var actual = newDriver.DetermineMonthlyRateByAge();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DetermineMonthlyRateByAge25_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(25);

            //act
            var expected = 180m;
            var actual = newDriver.DetermineMonthlyRateByAge();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Age must be between 16 and 25")]
        public void AgeIsNotValid_TooYoung_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Age must be between 16 and 25")]
        public void AgeIsNotValid_TooOld_ShouldSucceed()
        {
            //arrange
            var newDriver = new YoungDriver(55);
        }
    }
}
