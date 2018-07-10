using System;
using _06_OOP_Polymoephism_Demo_3.Models;
using _06_OOP_Polymoephism_Demo_3.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_OOP_Polymorphism_Unit_Tests
{
    [TestClass]
    public class UnitTest3
    {
        private Employee _employeeElevator;

        [TestMethod]
        public void Employee_ElevatorSwipeTest_ShouldPrintToConsole()
        {
            _employeeElevator = new Employee(new ElevatorService());//dependency injection
            _employeeElevator.SwipeCard();
        }
    }
}
