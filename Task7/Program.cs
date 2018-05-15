using System;

namespace Task7
{
    class Program
    {
        private const string StartInfo = "Task #7. Find all natural numbers which smaller than input number in the square.";
        private const string WrongInputInfo = "It should be a integer number.";
        private const string NumberInput = "Input a number, please.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string Answer = "Answer: {0}";

        static void Main(string[] args)
        {
            string endCheck;
            int number;
            do
            {
                Console.WriteLine(StartInfo);
                while (true)
                {
                    Console.WriteLine(NumberInput);
                    string temp = Console.ReadLine();
                    if (Int32.TryParse(temp, out number))
                        break;
                    else Console.WriteLine(WrongInputInfo);
                }
                NaturalNumbers naturalNumbers = new NaturalNumbers(number);
                //NaturalNumbers naturalNumbers = new NaturalNumbers(Int32.MaxValue);
                Console.WriteLine(string.Format(Answer, naturalNumbers.ToString()));
                Console.WriteLine(StartAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
