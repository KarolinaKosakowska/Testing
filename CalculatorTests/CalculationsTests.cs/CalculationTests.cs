using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculationsTests.cs
{
    [TestClass]
    public class CalculationTests
    {
        Calculations calculations = new Calculations();
        [TestMethod]
        public void Add_AddsTwoDouble_ReternsDouble()
        {
            double a = 1.3;
            double b = 2;
            double expected = 3.3;
            double actual = calculations.Add(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Substract_SubstractsTwoDouble_ReturnsDouble()
        {
            double a = 1.3;
            double b = 2;
            double expected = -0.7;
            double actual = calculations.Substract(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiple_MultipleTwoDouble_ReturnsDouble()
        {
            double a = 1.3;
            double b = 2;
            double expected = 2.6;
            double actual = calculations.Multiple(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_DivideTwoDoubleSecondParapetrNotZero_ReturnsDouble()
        {
            double a = 1.2;
            double b = 2;
            double expected = 0.6;
            double actual = calculations.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DivideTwoDoubleSecondParapetrIsZero_ReturnsDouble()
        {
            double a = 1.2;
            double b = 0;
            double actual = calculations.Divide(a, b);
           
        }
    }
}


