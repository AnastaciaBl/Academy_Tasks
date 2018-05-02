using System;

namespace Task1
{
    class Program
    {
        private static string startInfo = "Task #1. Drow a chess board.";
        private static string wrongInputInfo = "It should be a positive integer number.";
        private static string hightInput = "Input hight, please.";
        private static string widthInput = "Input width, please.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string answer = "Answer:";

        static void Main(string[] args)
        {
            string hight, width, endCheck;
            do
            {
                Console.WriteLine(startInfo);
                while (true)
                {
                    Console.WriteLine(hightInput);
                    hight = Console.ReadLine();
                    if (CheckUserInput.IsIntegerNumber(hight))
                        break;
                    else Console.WriteLine(wrongInputInfo);
                }
                while (true)
                {
                    Console.WriteLine(widthInput);
                    width = Console.ReadLine();
                    if (CheckUserInput.IsIntegerNumber(width))
                        break;
                    else Console.WriteLine(wrongInputInfo);
                }
                ChessBoard cb = new ChessBoard(Convert.ToInt32(hight), Convert.ToInt32(width));
                Console.WriteLine(answer);
                Console.WriteLine(cb.ToString());
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
