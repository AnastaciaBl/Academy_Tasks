using System;

namespace Task8
{
    class Program
    {
        private static string startInfo = "Task #8. Find all Fibonacci numbers in the interval.";
        private static string wrongInputInfo = "It should be a number.";
        private static string boundInput = "Input {0} bound, please.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string answer = "Answer: {0}";

        static void Main(string[] args)
        {
            string lowerBound, upperBound, endCheck;
            do
            {
                Console.WriteLine(startInfo);
                while (true)
                {
                    Console.WriteLine(string.Format(boundInput, "lower"));
                    lowerBound = Console.ReadLine();
                    if (CheckUserInput.IsDoubleNumber(lowerBound))
                        break;
                    else Console.WriteLine(wrongInputInfo);
                }
                while (true)
                {
                    Console.WriteLine(string.Format(boundInput, "upper"));
                    upperBound = Console.ReadLine();
                    if (CheckUserInput.IsDoubleNumber(upperBound))
                        break;
                    else Console.WriteLine(wrongInputInfo);
                }
                FibonacciNumbers f = new FibonacciNumbers(Convert.ToDouble(lowerBound), Convert.ToDouble(upperBound));
                Console.WriteLine(string.Format(answer, f.ToString()));
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
