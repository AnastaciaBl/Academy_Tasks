using System;
using System.Collections.Generic;

namespace Task6
{
    class HappyTickets
    {
        public int AmountOfHappyTickets { get; private set; }
        private IHappyTicketCounter countModel;
        private const int AmountOfNumbersInTicket = 6;
        private const int AmountOfTickets = 1000000;

        public HappyTickets(IHappyTicketCounter _countModel)
        {
            countModel = _countModel;
            AmountOfHappyTickets = countHappyTickets();
        }

        private int countHappyTickets()
        {
            int amountOfHappyTickets = 0;
            var tempNumber = new int[AmountOfNumbersInTicket];
            for (int i = 0; i < AmountOfTickets; i++)
            {
                if (countModel.IsHappyNumber(tempNumber))
                    amountOfHappyTickets++;
                if(i != AmountOfTickets - 1)
                    createNumberOfTicket(tempNumber);
            }
            return amountOfHappyTickets;
        }

        private void createNumberOfTicket(int[] ticket)
        {
            int indexOfPositionInNumber = AmountOfNumbersInTicket - 1;
            if (ticket[indexOfPositionInNumber] != 9)
                ticket[indexOfPositionInNumber]++;
            else
            {
                //when indexOfPositionInNumber == 0 ticket looks like "999999" so it shouldn`t try to create "1000000" ticket
                while (ticket[indexOfPositionInNumber] == 9)
                {
                    ticket[indexOfPositionInNumber] = 0;
                    indexOfPositionInNumber--;
                }
                ticket[indexOfPositionInNumber]++;
            }
        }
    }
}
