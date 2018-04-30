using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = new List<string>
            {
                "123060",
                "345480",
                "321002"
            };
            HappyTickets hp = new HappyTickets(tickets, new MoskovCount());
            Console.WriteLine("Moskov: " + hp.AmountOfHappyTickets);
            hp = new HappyTickets(tickets, new PiterCount());
            Console.WriteLine("Piter: " + hp.AmountOfHappyTickets);
            Console.ReadLine();
        }
    }
}
