﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL.Tests
{
    [TestClass()]
    public class CategoryTests
    {
        [TestMethod()]
        public void CalculatePriceTest()
        {
            double expected = 472;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(1, 200, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest1()
        {
            double expected = 416;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(2, 200, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest2()
        {
            double expected = 428;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(3, 200, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest3()
        {
            double expected = 472;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(4, 200, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}