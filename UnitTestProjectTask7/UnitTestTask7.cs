using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7;

namespace UnitTestProjectTask7
{
    [TestClass]
    public class UnitTestTask7
    {
        [TestMethod]
        public void NaturalNumbers_0()
        {
            NaturalNumbers n = new NaturalNumbers(0);
            string expected = "This set hasn`t numbers which smaller than 0 in the square.";
            string actual = n.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NaturalNumbers_2()
        {
            NaturalNumbers n = new NaturalNumbers(2);
            string expected = "1";
            string actual = n.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NaturalNumbers_10()
        {
            NaturalNumbers n = new NaturalNumbers(10);
            string expected = "1,2,3";
            string actual = n.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
