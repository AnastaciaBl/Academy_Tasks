using System;
using CheckUserInput;

namespace Task2
{
    class Program
    {
        private const string StartInfo = "Task #3. Envelope analise.";
        private const string NumberInput = "Input {0} envelope`s side, please.";
        private const string FirstEnvelopeInput = "Input data of the first envelope, please.";
        private const string SecondEnvelopeInput = "Input data of the second envelope, please.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string Answer = "Answer:";
        private const string EnvelopeFitsIntoAnother = "Yes, envelope ({0}x{1}) fits into another.";
        private const string EnvelopeNotFitsIntoAnother = "No, envelope ({0}x{1}) does not fit into another.";

        static void Main(string[] args)
        {
            string endCheck = string.Empty;
            double a, b;
            do
            {
                Envelope first, second;
                Console.WriteLine(StartInfo);
                while (true)
                {
                    inputSide(FirstEnvelopeInput, out a, out b);
                    first = new Envelope(Convert.ToDouble(a), Convert.ToDouble(b));
                    inputSide(SecondEnvelopeInput, out a, out b);
                    second = new Envelope(Convert.ToDouble(a), Convert.ToDouble(b));
                    break;
                }
                Console.WriteLine(Answer);
                PrintAnswer(first, second);
                PrintAnswer(second, first);
                Console.WriteLine(StartAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
            //Envelope e1 = new Envelope(13, 88);
            //Envelope e2 = new Envelope(81, 59);
        }

        private static void inputSide(string nameOfEnvelope, out double a, out double b)
        {
            Console.WriteLine(nameOfEnvelope);
            while (true)
            {
                string temp = inputSide("A");
                if (Double.TryParse(temp, out a) && CheckDoubleNumbers.IsPositiveDoubleNumber(a))
                    break;
            }
            while (true)
            {
                string temp = inputSide("B");
                if (Double.TryParse(temp, out b) && CheckDoubleNumbers.IsPositiveDoubleNumber(b))
                    break;
            }
        }

        private static string inputSide(string nameOfSide)
        {
            Console.WriteLine(NumberInput, nameOfSide);
            return Console.ReadLine();
        }

        private static void PrintAnswer(Envelope first, Envelope second)
        {
            if (first.IsFitsIntoThisEnvelope(second))
                Console.WriteLine(EnvelopeFitsIntoAnother, second.A, second.B);
            else
                Console.WriteLine(EnvelopeNotFitsIntoAnother, second.A, second.B);
        }
    }
}
