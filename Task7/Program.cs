using System;

namespace Task7
{
    class Program
    {
        private static string startInfo = "Task #7. Find all natural numbers which smaller than input number in the square.";
        private static string wrongInputInfo = "It should be a integer number.";
        private static string numberInput = "Input a number, please.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string answer = "Answer: {0}";

        static void Main(string[] args)
        {
            string number, endCheck;
            do
            {
                Console.WriteLine(startInfo);
                while (true)
                {
                    Console.WriteLine(numberInput);
                    number = Console.ReadLine();
                    if (CheckUserInput.IsIntegerNumber(number))
                        break;
                    else Console.WriteLine(wrongInputInfo);
                }
                NaturalNumbers naturalNumbers = new NaturalNumbers(Convert.ToInt32(number));
                Console.WriteLine(string.Format(answer, naturalNumbers.ToString()));
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
