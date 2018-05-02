using System;
using System.Collections.Generic;

namespace Task8
{
    class FibonacciNumbers
    {
        public double[] Numbers { get; private set; }
        private double lowerBound;
        private double LowerBound
        {
            get { return lowerBound; }
            set
            {
                if (value < 0) lowerBound = 0;
                else lowerBound = value;
            }
        }
        private double UpperBound { get; set; }
        private double lowerIndex = 0;
        private double upperIndex = 100;

        public FibonacciNumbers(double lowerBound, double upperBound)
        {
            if (lowerBound <= upperBound)
            {
                LowerBound = lowerBound;
                UpperBound = upperBound;
            }
            else
            {
                LowerBound = upperBound;
                UpperBound = lowerBound;
            }
            Numbers = CreateSetOfNumbers();
        }

        private double[] CreateSetOfNumbers()
        {
            List<double> numbers = new List<double>();
            double indexOfFirstNumber = FindIndexOfFirstNumber();
            double number = FindFibonacciNumber(indexOfFirstNumber);
            double nextNumber = FindFibonacciNumber(indexOfFirstNumber + 1);
            numbers.Add(number);
            while(nextNumber <= UpperBound)
            {
                numbers.Add(nextNumber);
                double temp = nextNumber;
                nextNumber += number;
                number = temp;
            }
            return numbers.ToArray();
        }

        private double FindIndexOfFirstNumber()
        {
            double index = FindIndexOfNumberInInterval();
            if(index != -1)
                index = FindIndexOfTheSmallestNumberInInterval(index);
            return index;
        }

        private double FindIndexOfNumberInInterval()
        {
            double index = Math.Round((upperIndex - lowerIndex) / 2);
            double number = FindFibonacciNumber(index);
            while (IsNumberOutOfBounds(number))
            {
                if (number > UpperBound)
                {
                    upperIndex = index;
                }
                else if (number < LowerBound)
                {
                    lowerIndex = index;
                    upperIndex = upperIndex + index;
                }
                else
                    break;
                index = index = Math.Round((upperIndex - lowerIndex) / 2);
                number = FindFibonacciNumber(index);
            }
            return index;
        }

        private double FindIndexOfTheSmallestNumberInInterval(double index)
        {
            double number = FindFibonacciNumber(index);
            while(true)
            {
                if (number < LowerBound)
                {
                    index++;
                    break;
                }
                else if (number == LowerBound) break;
                else
                {
                    index--;
                    number = FindFibonacciNumber(index);
                }
            }
            return index;
        }

        private bool IsNumberOutOfBounds(double number)
        {
            if (number > UpperBound || number < LowerBound)
                return true;
            else
                return false;
        }

        private double FindFibonacciNumber(double indexOfNumber)
        {
            double fNumber = (Math.Pow((1 + Math.Sqrt(5)) / 2, indexOfNumber) - 
                Math.Pow((1 - Math.Sqrt(5)) / 2, indexOfNumber)) / 
                Math.Sqrt(5);
            return Math.Round(fNumber);
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < Numbers.Length - 1; i++)
                str += Numbers[i] + ",";
            str += Numbers[Numbers.Length - 1];
            return str;
        }
    }
}
