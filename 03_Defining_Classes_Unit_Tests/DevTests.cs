using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_2;

namespace _03_Defining_Classes_Unit_Tests
{
    
    [TestClass]
    public class DevTests
    {
        //private variable
        private Developers _developer;

        [TestInitialize]
        public void Arrange()
        {
            //arrange
            _developer = new Developers(666, "Danzig", false);
        }
        [TestMethod]
        public void EmployeeConstructorInstantiates_ShouldSucceed()
        {
            Arrange();

            //act
            var actualId = _developer.Id;
            var actualLastName = _developer.LastName;
            var actualPluralsightAccount = _developer.HasPluralsight;

            var expectedId = 666;
            var expectedLastName = "Danzig";
            var expectedPluralsightAccount = false;

            //Assert
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedLastName, actualLastName);
            Assert.AreEqual(expectedPluralsightAccount, actualPluralsightAccount);
        }

        [TestMethod]
        public void AddingDeveloperToList_ShouldSucceed()
        {
            //Arrange
            Arrange();
            var team = new Team();

            //Act
            team.AddDeveloper(_developer);
            var expectedCount = 1;
            var actualCount = team.GetListCount();

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
