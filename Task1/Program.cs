using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard cb = new ChessBoard(5, 10);
            Console.WriteLine(cb.ToString());
            Console.ReadLine();
        }
    }
}
