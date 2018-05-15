using System;
using CheckUserInput;

namespace Task1
{
    class Program
    {
        private const string StartInfo = "Task #1. Drow a chess board.";
        private const string WrongInputInfo = "It should be a positive integer number.";
        private const string HightInput = "Input hight, please.";
        private const string WidthInput = "Input width, please.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string Answer = "Answer:";

        static void Main(string[] args)
        {
            string hight, width, endCheck;
            int iHight, iWidth;
            do
            {
                Console.WriteLine(StartInfo);
                while (true)
                {
                    Console.WriteLine(HightInput);
                    hight = Console.ReadLine();
                    if (Int32.TryParse(hight, out iHight) && CheckIntegerNumbers.IsNaturalNumber(iHight))
                       break;
                    else Console.WriteLine(WrongInputInfo);
                }
                while (true)
                {
                    Console.WriteLine(WidthInput);
                    width = Console.ReadLine();
                    if (Int32.TryParse(width, out iWidth) && CheckIntegerNumbers.IsNaturalNumber(iWidth))
                        break;
                    else Console.WriteLine(WrongInputInfo);
                }
                ChessBoard cb = new ChessBoard(iHight, iWidth);
                Console.WriteLine(Answer);
                Console.WriteLine(cb.ToString());
                Console.WriteLine(StartAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
