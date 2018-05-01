using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Envelope e1 = new Envelope(13, 88);
            //Envelope e2 = new Envelope(81, 59);
            Envelope e1 = new Envelope(13, 10);
            Envelope e2 = new Envelope(5, 40);
            Console.WriteLine(e2.IsFitsIntoThisEnvelope(e1));
            Console.ReadLine();
        }
    }
}
