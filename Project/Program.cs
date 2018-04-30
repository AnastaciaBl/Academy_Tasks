using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciNumbers f = new FibonacciNumbers(2, 11000);
            Console.WriteLine(f.ToString());
            Console.ReadLine();
        }
    }
}
