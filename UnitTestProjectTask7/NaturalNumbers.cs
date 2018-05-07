using System.Collections.Generic;

namespace Task7
{
    class NaturalNumbers
    {
        public int[] Numbers { get; private set; }
        private int checkNumber;

        public NaturalNumbers(int _checkNumber)
        {
            checkNumber = _checkNumber;
            Numbers = createSetOfNumbers();
        }

        private int[] createSetOfNumbers()
        {
            List<int> setOfNumbers = new List<int>();
            int tempNumber = 1;
            while(tempNumber*tempNumber<checkNumber)
            {
                setOfNumbers.Add(tempNumber);
                tempNumber++;
            }
            return setOfNumbers.ToArray();
        }

        public override string ToString()
        {
            string str = string.Empty;
            if (Numbers.Length != 0)
            {
                for (int i = 0; i < Numbers.Length - 1; i++)
                    str += Numbers[i] + ",";
                str += Numbers[Numbers.Length - 1];
            }
            else str = string.Format("This set hasn`t numbers which smaller than {0} in the square.", checkNumber);
            return str;
        }
    }
}
