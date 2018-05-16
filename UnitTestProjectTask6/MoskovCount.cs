using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class MoskovCount : IHappyTicketCounter
    {
        public bool IsHappyNumber(int[] ticket)
        {
            int leftSum = 0, rightSum = 0;
            int centerIndex = ticket.Length / 2;
            for (int i = 0; i < centerIndex; i++)
            {
                leftSum += ticket[i];
            }
            for (int i = centerIndex; i < ticket.Length; i++)
            {
                rightSum += ticket[i];
            }
            if (leftSum == rightSum) return true;
            else return false;
        }
    }
}
