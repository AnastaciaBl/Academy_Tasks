using System;

namespace Task2
{
    class Program
    {
        private static string startInfo = "Task #3. Envelope analise.";
        private static string numberInput = "Input {0} envelope`s side, please.";
        private static string firstEnvelopeInput = "Input data of the first envelope, please.";
        private static string secondEnvelopeInput = "Input data of the second envelope, please.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string answer = "Answer: {0}";

        static void Main(string[] args)
        {
            string a, b, endCheck = string.Empty;
            do
            {
                Envelope first, second;
                Console.WriteLine(startInfo);
                while (true)
                {
                    inputSide(firstEnvelopeInput, out a, out b);
                    first = new Envelope(Convert.ToDouble(a), Convert.ToDouble(b));
                    inputSide(secondEnvelopeInput, out a, out b);
                    second = new Envelope(Convert.ToDouble(a), Convert.ToDouble(b));
                    break;
                }
                Console.WriteLine(answer, first.IsFitsIntoThisEnvelope(second));
                Console.WriteLine(answer, second.IsFitsIntoThisEnvelope(first));
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
            //Envelope e1 = new Envelope(13, 88);
            //Envelope e2 = new Envelope(81, 59);
        }

        private static void inputSide(string nameOfEnvelope, out string a, out string b)
        {
            Console.WriteLine(nameOfEnvelope);
            while (true)
            {
                a = inputSide("A");
                if (CheckUserInput.IsDoubleNumber(a))
                    break;
            }
            while (true)
            {
                b = inputSide("B");
                if (CheckUserInput.IsDoubleNumber(b))
                    break;
            }
        }

        private static string inputSide(string nameOfSide)
        {
            Console.WriteLine(numberInput, nameOfSide);
            return Console.ReadLine();
        }
    }
}
