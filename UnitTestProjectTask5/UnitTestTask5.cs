using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;

namespace UnitTestProjectTask5
{
    [TestClass]
    public class UnitTestTask5
    {
        [TestMethod]
        public void StringNumber_125()
        {
            Number n = new Number("125");
            string expected = "сто двадцать пять ";
            string actual = n.CreateResultNumber();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringNumber_0()
        {
            Number n = new Number("0");
            string expected = "ноль";
            string actual = n.CreateResultNumber();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringNumber_5()
        {
            Number n = new Number("5");
            string expected = "пять ";
            string actual = n.CreateResultNumber();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringNumber_21()
        {
            Number n = new Number("21");
            string expected = "двадцать один ";
            string actual = n.CreateResultNumber();
            Assert.AreEqual(expected, actual);
        }
    }
}
