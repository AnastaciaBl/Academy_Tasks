using System;
using System.Collections.Generic;

namespace Task6
{
    class HappyTickets
    {
        public List<string> Tickets { get; private set; }
        private ICount countModel;
        public int AmountOfHappyTickets { get; private set; }

        public HappyTickets(List<string> _tickets, ICount _countModel)
        {
            Tickets = _tickets;
            countModel = _countModel;
            AmountOfHappyTickets = countHappyTickets();
        }

        public int countHappyTickets()
        {
            int amountOfHappyTickets = 0;
            for(int i=0;i<Tickets.Count;i++)
            {
                int[] temp = createSetOfNumbersFromString(Tickets[i]);
                if (countModel.IsHappyNumber(temp))
                    amountOfHappyTickets++;
            }
            return amountOfHappyTickets;
        }

        private int[] createSetOfNumbersFromString(string str)
        {
            int[] setOfNumbers = new int[str.Length];
            for(int i=0;i<setOfNumbers.Length;i++)
            {
                setOfNumbers[i] = (int)Char.GetNumericValue(str[i]);
            }
            return setOfNumbers;
        }
    }
}
