using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_3;
using _03_Defining_Classes_Exercise_4;

namespace _03_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class SalesRepoTests
    {
        private SalesRepository _salesRepository;

        [TestInitialize]
        public void Arrange()
        {
            _salesRepository = new SalesRepository();
        }

        [TestMethod]
        public void SalesRepoListIsInstantiated_ShouldSucceed()
        {
            //arrange
            var salesMember1 = new SalesMember("Danzig", 2500.25m);
            var salesMember2 = new SalesMember("Frankenstein", 3500.25m);


            //act
            _salesRepository.AddSalesMemberToList(salesMember1);
            _salesRepository.AddSalesMemberToList(salesMember2);

            var actual = _salesRepository.GetListCount();
            var expected = 2;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTotal_ShouldSucceed()
        {
            //arrange
            var salesMember1 = new SalesMember("Danzig", 2500.25m);
            var salesMember2 = new SalesMember("Frankenstein", 3500.25m);


            //act
            _salesRepository.AddSalesMemberToList(salesMember1);
            _salesRepository.AddSalesMemberToList(salesMember2);

            var actual = _salesRepository.AddTotalSales();
            var expected = 6000.50m;


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}