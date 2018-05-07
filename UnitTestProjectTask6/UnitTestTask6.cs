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
        public void HappyTickets_Moskow_3()
        {
            List<string> tickets = new List<string>()
            {
                "123123",
                "000111",
                "555555",
                "246606"
            };
            ICount model = new MoskovCount();
            HappyTickets ht = new HappyTickets(tickets, model);
            int expected = 3;
            int actual = ht.countHappyTickets();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HappyTickets_Moskow_0()
        {
            List<string> tickets = new List<string>()
            {
                "000111",
                "555000",
            };
            ICount model = new MoskovCount();
            HappyTickets ht = new HappyTickets(tickets, model);
            int expected = 0;
            int actual = ht.countHappyTickets();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HappyTickets_Piter_2()
        {
            List<string> tickets = new List<string>()
            {
                "123123",
                "000111",
                "555555",
                "246606"
            };
            ICount model = new PiterCount();
            HappyTickets ht = new HappyTickets(tickets, model);
            int expected = 2;
            int actual = ht.countHappyTickets();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HappyTickets_Piter_0()
        {
            List<string> tickets = new List<string>()
            {
                "100123",
                "000111",
                "246606"
            };
            ICount model = new PiterCount();
            HappyTickets ht = new HappyTickets(tickets, model);
            int expected = 0;
            int actual = ht.countHappyTickets();
            Assert.AreEqual(expected, actual);
        }
    }
}
