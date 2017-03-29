using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab01.DEV1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab01.DEV1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        [TestCategory("aa")]
        public void AddTest_1()
        {
            Calculator calculator = new Calculator();
            calculator.Add(3);
            int result = calculator.Result;
            Assert.AreEqual(result, 3);
        }

        [TestMethod()]
        [TestCategory("bb")]
        public void AddTest_2()
        {
            Calculator calculator = new Calculator();
            calculator.Add(3);
            int result = calculator.Result;
            Assert.AreEqual(result, 3);
        }
    }
}