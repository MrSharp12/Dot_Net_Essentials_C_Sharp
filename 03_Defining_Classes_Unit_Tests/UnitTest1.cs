using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_1;
using _03_Defining_Classes_Exercise_2;

namespace _03_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //private variable
        private Employee _employee;

        [TestInitialize]
        public void Arrange()
        {
            //arrange
            _employee = new Employee(666, "Danzig", 54, 3);
        }

        [TestMethod]
        public void EmployeeConstructorInstantiates_ShouldSucceed()
        {
            //Arrange
            Arrange();

            //Act
            var actualId = _employee.IdNumber;
            var actualLastName = _employee.LastName;
            var actualAge = _employee.Age;
            var actualYearsOfEmployment = _employee.YearsOfEmployment;

            var expectedId = 666;
            var expectedLastName = "Danzig";
            var expectedAge = 54;
            var expectedYearsOfEmployment = 3;

            //Assert
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedLastName, actualLastName);
            Assert.AreEqual(expectedAge, actualAge);
            Assert.AreEqual(expectedYearsOfEmployment, actualYearsOfEmployment);
        }
    }
}
