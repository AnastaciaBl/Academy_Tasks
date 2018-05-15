using System;
using System.Collections.Generic;
using CheckUserInput;
using System.Text;
using static System.Math;

namespace Task8
{
    class FibonacciNumbers
    {
        public double[] Numbers { get; private set; }
        private string textRepresentation;
        private double lowerBound, upperBound;
        private double LowerBound
        {
            get { return lowerBound; }
            set
            {
                if (CheckDoubleNumbers.IsPositiveDoubleNumber(value)) lowerBound = value;
                else throw new ArgumentException("It should be a positive double number.");
            }
        }
        private double UpperBound
        {
            get { return upperBound; }
            set
            {
                if (CheckDoubleNumbers.IsPositiveDoubleNumber(value)) upperBound = value;
                else throw new ArgumentException("It should be a positive double number.");
            }
        }
        private double lowerIndex = 0;
        private double upperIndex = 100;

        public FibonacciNumbers() { }

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
            Numbers = createSetOfNumbers();
            textRepresentation = createTextRepresentationOfFibonacciNumbers();
        }

        private double[] createSetOfNumbers()
        {
            List<double> numbers = new List<double>();
            double indexOfFirstNumber = findIndexOfFirstNumber();
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

        private double findIndexOfFirstNumber()
        {
            double index = findIndexOfNumberInInterval();
            if(index != -1)
                index = findIndexOfTheSmallestNumberInInterval(index);
            return index;
        }

        private double findIndexOfNumberInInterval()
        {
            double index = Round((upperIndex - lowerIndex) / 2);
            double number = FindFibonacciNumber(index);
            while (isNumberOutOfBounds(number))
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
                index = index = Round((upperIndex - lowerIndex) / 2);
                number = FindFibonacciNumber(index);
            }
            return index;
        }

        private double findIndexOfTheSmallestNumberInInterval(double index)
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

        private bool isNumberOutOfBounds(double number)
        {
            if (number > UpperBound || number < LowerBound)
                return true;
            else
                return false;
        }

        public double FindFibonacciNumber(double indexOfNumber)
        {
            double fNumber = (Pow((1 + Sqrt(5)) / 2, indexOfNumber) - 
                Pow((1 - Sqrt(5)) / 2, indexOfNumber)) / 
                Sqrt(5);
            return Round(fNumber);
        }

        private string createTextRepresentationOfFibonacciNumbers()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                str.Append(Numbers[i]);
                str.Append(",");
            }
            str.Append(Numbers[Numbers.Length - 1]);
            return str.ToString();
        }

        public override string ToString()
        {
            return textRepresentation;
        }
    }
}
