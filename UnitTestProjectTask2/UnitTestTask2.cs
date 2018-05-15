using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace UnitTestProjectTask2
{
    [TestClass]
    public class UnitTestTask2
    {
        [TestMethod]
        public void Envelope_10on5_fit_into_15on20()
        {
            Envelope e1 = new Envelope(10, 5);
            Envelope e2 = new Envelope(15, 20);
            bool expected = true;
            bool actual = e2.IsFitsIntoThisEnvelope(e1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Envelope_15on20_NOT_fit_into_10on5()
        {
            Envelope e1 = new Envelope(10, 5);
            Envelope e2 = new Envelope(15, 20);
            bool expected = false;
            bool actual = e1.IsFitsIntoThisEnvelope(e2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Envelope_10on2_fit_into_9on9()
        {
            Envelope e1 = new Envelope(10, 2);
            Envelope e2 = new Envelope(9, 9);
            bool expected = true;
            bool actual = e2.IsFitsIntoThisEnvelope(e1);
            Assert.AreEqual(expected, actual);
        }
    }
}
