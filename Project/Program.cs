using System;
using CheckUserInput;

namespace Task8
{
    class Program
    {
        private const string StartInfo = "Task #8. Find all Fibonacci numbers in the interval.";
        private const string WrongInputInfo = "It should be a positive number.";
        private const string BoundInput = "Input {0} bound, please.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string Answer = "Answer: {0}";

        static void Main(string[] args)
        {
            string endCheck;
            double lowerBound, upperBound;
            do
            {
                Console.WriteLine(StartInfo);
                inputBounds(out lowerBound, "lower");
                inputBounds(out upperBound, "upper");
                FibonacciNumbers f = new FibonacciNumbers(lowerBound, upperBound);
                //FibonacciNumbers f = new FibonacciNumbers(lowerBound, Int64.MaxValue);
                Console.WriteLine(string.Format(Answer, f.ToString()));
                Console.WriteLine(StartAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }

        private static void inputBounds(out double bound, string typeOfBount)
        {
            while (true)
            {
                Console.WriteLine(string.Format(BoundInput, typeOfBount));
                string temp = Console.ReadLine();
                if (Double.TryParse(temp, out bound) && CheckDoubleNumbers.IsPositiveDoubleNumber(bound))
                    break;
                else Console.WriteLine(WrongInputInfo);
            }
        }
    }
}
