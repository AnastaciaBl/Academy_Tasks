using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class NaturalNumbers
    {
        public int[] Numbers { get; private set; }
        private double checkNumber;
        private string textRepresentation;

        public NaturalNumbers(int _checkNumber)
        {
            checkNumber = System.Math.Sqrt(_checkNumber);
            Numbers = createSetOfNumbers();
            textRepresentation = createTextRepresentation();
        }

        public override string ToString()
        {
            return textRepresentation;
        }

        private int[] createSetOfNumbers()
        {
            List<int> setOfNumbers = new List<int>();
            int tempNumber = 1;
            while (tempNumber < checkNumber)
            {
                setOfNumbers.Add(tempNumber);
                tempNumber++;
            }
            return setOfNumbers.ToArray();
        }

        private string createTextRepresentation()
        {
            if (Numbers.Length != 0)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < Numbers.Length - 1; i++)
                {
                    sb.Append(Numbers[i]);
                    sb.Append(',');
                }
                sb.Append(Numbers[Numbers.Length - 1]);
                return sb.ToString();
            }
            else return string.Format("This set hasn`t numbers which smaller than {0} in the square.", checkNumber);            
        }
    }
}
