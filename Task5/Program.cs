using System;

namespace Task5
{
    class Program
    {
        private const string startInfo = "Task #6. Turn integer number into string.";
        private const string wrongInputInfo = "It should be a integer number [from 0 to 999].";
        private const string numberInput = "Input a integer number [from 0 to 999], please.";
        private const string startAgain = "Do you want to start a program again? y/n";
        private const string answer = "Answer: {0}";

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
                    int checkResult;
                    if (Int32.TryParse(number, out checkResult))
                        break;
                    else Console.WriteLine(wrongInputInfo);
                }
                Number intNumber = new Number(number);
                Console.WriteLine(string.Format(answer, intNumber.ToString()));
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
