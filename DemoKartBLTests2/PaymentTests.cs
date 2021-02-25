using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL.Tests
{
    [TestClass()]
    public class PaymentTests
    {
        [TestMethod()]
        public void CalcCGSTTest()
        {
            double expected = 200;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalcCGST(1, 200);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcCGSTTest1()
        {
            double expected = 207;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalcCGST(2, 200);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcSGSTTest()
        {
            double expected = 200;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalcCGST(1, 200);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcSGSTTest1()
        {
            double expected = 207;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalcCGST(2, 200);
            Assert.AreEqual(expected, actual);
        }
    }
}