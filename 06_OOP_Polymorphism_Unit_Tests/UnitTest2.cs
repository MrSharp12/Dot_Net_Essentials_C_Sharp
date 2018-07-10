using System;
using _06_OOP_Polymorphism_Exercise_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_OOP_Polymorphism_Unit_Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Sales _sales;
        private Coder _coder;
        private Claims _claims;

        [TestInitialize]
        public void Arrange()
        {
            _sales = new Sales();
            _sales.SalesOffOfMonthlyGoal = 2000m;
            _sales.MonthlyGoal = 8000m;
            _sales.SalesMeeting = "ABC Corp";
            _sales.SalesForTheDay = 400m;

            _coder = new Coder();
            _coder.NewLanguage = "Flux";
            _coder.StandupMeeting = 20;
            _coder.LinesOfCode = 400;

            _claims = new Claims();
            _claims.ThisMonthHoliday = "Fourth of July";
            _claims.ClaimsTotal = 52;
            _claims.ClaimsFinishedToday = 42;
        }

        [TestMethod]
        public void Sales_EnterBuildingMethod_ShouldReturnString()
        {
            //act
            var expected = _sales.EnteredBuildingMessage();//for future referemce, switch actual and expected

            var actual = "Hi!  You are 2000 dollars from our monthly goal.  Also, remember our monthly goal is 8000 dollars";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sales_EnteredElevatorMethod_ShouldReturnString()
        {
            //act
            var expected = _sales.EnteredElevatorMessage();

            var actual = "Remember, you have a meeting with ABC Corp today";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sales_LeftFloorMethod_ShouldReturnString()
        {
            //act
            var expected = _sales.LeftFloorMessage();

            var actual = "Great job.  You sold 400 dollars today.  You are 1600 dollars away from the monthly goal";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Coder_EnterBuildingMethod_ShouldReturnString()
        {
            //act
            var expected = _coder.EnteredBuildingMessage();

            var actual = "A new language, Flux, just came out today.  Give it a look!";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Coder_EnteredElevatorMethod_ShouldReturnString()
        {
            //act
            var expected = _coder.EnteredElevatorMessage();

            var actual = "You have a standup in 20 minutes";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Coder_LeftFloorMethod_ShouldReturnString()
        {
            //act
            var expected = _coder.LeftFloorMessage();

            var actual = "You pushed 400 lines of code";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claims_EnterBuildingMethod_ShouldReturnString()
        {
            //act
            var expected = _claims.EnteredBuildingMessage();

            var actual = "This month's holiday is the Fourth of July";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claims_EnteredElevatorMethod_ShouldReturnString()
        {
            //act
            var expected = _claims.EnteredElevatorMessage();

            var actual = "You have 52 claims left";

            //asseret
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claims_LeftFloorMethod_ShouldReturnString()
        {
            //act
            var expected = _claims.LeftFloorMessage();

            var actual = "You have 10 claims left";

            //asseret
            Assert.AreEqual(expected, actual);
        }
    }
}
