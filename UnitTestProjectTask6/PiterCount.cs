using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class PiterCount : IHappyTicketCounter
    {
        public bool IsHappyNumber(int[] ticket)
        {
            int oddSum = 0, evenSum = 0;
            for (int i = 1; i < ticket.Length; i = i+2)
            {
                oddSum += ticket[i];
            }
            for (int i = 0; i < ticket.Length; i = i + 2)
            {
                evenSum += ticket[i];
            }
            if (oddSum == evenSum) return true;
            else return false;
        }
    }
}
