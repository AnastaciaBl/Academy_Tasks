using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6;
using System.Collections.Generic;

namespace UnitTestProjectTask6
{
    [TestClass]
    public class UnitTestTask6
    {
        [TestMethod]
        public void HappyTickets_Moskow_55252()
        {
            IHappyTicketCounter model = new MoskovCount();
            HappyTickets ht = new HappyTickets(model);
            int expected = 55252;
            int actual = ht.AmountOfHappyTickets;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HappyTickets_Piter_55252()
        {
            IHappyTicketCounter model = new PiterCount();
            HappyTickets ht = new HappyTickets(model);
            int expected = 55252;
            int actual = ht.AmountOfHappyTickets;
            Assert.AreEqual(expected, actual);
        }
    }
}
