using System;
using _04_OOP_Encapsulation_Exercise_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_OOP_Encapsulation_Unit_Tests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void CheckIfHasSetBalanceGetSubtracted_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.ID = 666;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);

            //act
            var expected = 90m;
            var actual = dev.Balance;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfHasPurchasedCourseIsFalseOnInstantiation_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();

            //act
            var expected = false;
            var actual = dev.HasPurchasedCourse;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PurchaseCourse_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);

            //act
            var expectedBalance = 90m;
            var actual = dev.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actual);
        }

        [TestMethod]
        public void CheckIFListOfCoursesIsPopulating_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);

            //act
            var expected = 1;
            var actual = dev.GetDevListCount();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PurchaseCourseCallingAddMethod_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var course2 = new UdemyCourse("Intro to .NET", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
            trainingList.PurchaseCourse(course2, dev);

            //act
            var expectedCount = 2;
            var actualCount = trainingList.GetListCount();

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void ViewEmployeeCourseListMethod_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var dev2 = new Developer();
            dev2.FullName = "Frankenstein";
            dev2.ID = 001;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var course2 = new UdemyCourse("Intro to .NET", 10m);
            var course3 = new UdemyCourse("MVC Essentials", 10m);
            var course4 = new UdemyCourse("C# Design Patterns", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
            trainingList.PurchaseCourse(course2, dev);
            trainingList.PurchaseCourse(course3, dev);
            trainingList.PurchaseCourse(course3, dev2);
            trainingList.PurchaseCourse(course4, dev2);
            Console.WriteLine(trainingList.ViewDevList(dev));

            //act
            var expected = "Course Name: Intro to C#, Course Price: 10, Remaining Balance: 70\nCourse Name: Intro to .NET, Course Price: 10, Remaining Balance: 70\nCourse Name: MVC Essentials, Course Price: 10, Remaining Balance: 70\n";
            var actual = trainingList.ViewDevList(dev);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ViewEmployeeCourseListMethodCheckSecondDev_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var dev2 = new Developer();
            dev2.FullName = "Frankenstein";
            dev2.ID = 001;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var course2 = new UdemyCourse("Intro to .NET", 10m);
            var course3 = new UdemyCourse("MVC Essentials", 10m);
            var course4 = new UdemyCourse("C# Design Patterns", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
            trainingList.PurchaseCourse(course2, dev);
            trainingList.PurchaseCourse(course3, dev);
            trainingList.PurchaseCourse(course3, dev2);
            trainingList.PurchaseCourse(course4, dev2);
            Console.WriteLine(trainingList.ViewDevList(dev2));

            //act
            var expected = "Course Name: MVC Essentials, Course Price: 10, Remaining Balance: 80\nCourse Name: C# Design Patterns, Course Price: 10, Remaining Balance: 80\n";
            var actual = trainingList.ViewDevList(dev2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ViewMasterCourseListMethod_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var dev2 = new Developer();
            dev2.FullName = "Frankenstein";
            dev2.ID = 001;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var course2 = new UdemyCourse("Intro to .NET", 10m);
            var course3 = new UdemyCourse("MVC Essentials", 10m);
            var course4 = new UdemyCourse("C# Design Patterns", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
            trainingList.PurchaseCourse(course2, dev);
            trainingList.PurchaseCourse(course3, dev2);
            trainingList.PurchaseCourse(course4, dev2);
            Console.WriteLine(trainingList.ViewMasterList());

            //act
            var expected = "Course Name: Intro to C#, Course Price: 10\nCourse Name: Intro to .NET, Course Price: 10\nCourse Name: MVC Essentials, Course Price: 10\nCourse Name: C# Design Patterns, Course Price: 10\n";
            var actual = trainingList.ViewMasterList();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MasterCourseListDoesNotListMutlipleInstancesOfTheSameTraining_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var dev2 = new Developer();
            dev2.FullName = "Frankenstein";
            dev2.ID = 001;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var course2 = new UdemyCourse("Intro to .NET", 10m);
            var course3 = new UdemyCourse("MVC Essentials", 10m);
            var course4 = new UdemyCourse("C# Design Patterns", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
            trainingList.PurchaseCourse(course2, dev);
            trainingList.PurchaseCourse(course3, dev2);
            trainingList.PurchaseCourse(course4, dev2);
            trainingList.PurchaseCourse(course3, dev);
            Console.WriteLine(trainingList.ViewMasterList());

            //act
            var expected = "Course Name: Intro to C#, Course Price: 10\nCourse Name: Intro to .NET, Course Price: 10\nCourse Name: MVC Essentials, Course Price: 10\nCourse Name: C# Design Patterns, Course Price: 10\n";
            var actual = trainingList.ViewMasterList();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfHasPurchasedCourseIsTrue_ShouldSucceed()
        {
            //arrange
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var course1 = new UdemyCourse("Intro to C#", 10m);
            var course2 = new UdemyCourse("Intro to .NET", 10m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
            trainingList.PurchaseCourse(course2, dev);

            //act
            var expected = true;
            var actual = dev.HasPurchasedCourse;
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "You do not have enough money to purchase course.")]
        public void PurchaseCourseThrowsException_ShouldSucceed()
        {
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var course1 = new UdemyCourse("Intro to C#", 200m);
            var trainingList = new DevTrainingRepo();
            trainingList.PurchaseCourse(course1, dev);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Developer has not purchased any courses.")]
        public void ViewDevListThrowsException_ShouldSucceed()
        {
            var dev = new Developer();
            dev.FullName = "Danzig";
            dev.ID = 666;
            var trainingList = new DevTrainingRepo();
            trainingList.ViewDevList(dev);
        }
    }
}
