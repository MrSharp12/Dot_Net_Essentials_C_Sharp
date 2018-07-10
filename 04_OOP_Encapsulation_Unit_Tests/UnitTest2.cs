using System;
using _04_OOP_Encapsulation_Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_OOP_Encapsulation_Unit_Tests
{
    [TestClass]
    public class UnitTest2
    {

        //private Room _room;

        //[TestInitialize]
        //public void Arrange()
        //{
        //    _room = new Room(12, 10, 10);
        //}

        [TestMethod]
        public void SettingRoomHeight_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 10, 15);

            //act
            var expected = 12;
            var actual = room.Height;

            //arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Invalid Height")]
        public void SettingRoomHeightShouldThrowError_ShouldSucceed()
        {
            //arrange
            var room = new Room(2, 10, 15);
        }

        [TestMethod]
        public void SettingRoomLength_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 10, 15);

            //act
            var expected = 10;
            var actual = room.Length;

            //arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Invalid Length")]
        public void SettingRoomLengthShouldThrowError_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 500, 15);
        }

        [TestMethod]
        public void SettingRoomWidth_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 10, 15);

            //act
            var expected = 15;
            var actual = room.Width;

            //arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Invalid Width")]
        public void SettingRoomWidthShouldThrowError_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 10, 1);
        }

        [TestMethod]
        public void CalculateSurfaceAreaOfWalls_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 10, 10);

            //act
            var expected = 120;
            var actual = room.CalculateSurfaceAreaOfWalls();

            //arrange
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateRoomDimensions_ShouldSucceed()
        {
            //arrange
            var room = new Room(12, 10, 15);

            //act
            var expected = 150;
            var actual = room.CalculateRoomDimensions();

            //arrange
            Assert.AreEqual(expected, actual);
        }

        //look more into this for testing
        //[DataTestMethod]
        //[DataRow(12,10,15)]
        //[DataRow(2, 14, 23)]
        //[DataRow(16, 6, 88)]
        //public void ConstructorWithMultipleParams(int h, int l, int w)
        //{
        //    Room room = new Room(h, l, w);

        //}
    }
}
