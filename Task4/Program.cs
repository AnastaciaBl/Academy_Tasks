using System;
using System.IO;

namespace Task4
{
    class Program
    {
        private const string StartInfo = "Task #4. File parser.";
        private const string VarInput = "1 - count word\n2 - change word";
        private const string CountWordInput = "Input <path to file> <word for count>, please.";
        private const string ChangeWordInput = "Input <path to file> <word for search> <word for change>, please.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string Answer = "Amount of /{0}/ in the text: {1}";
        private const string AnswerChange = "File was changed.";

        static void Main(string[] args)
        {
            string endCheck = string.Empty;
            string[] path;
            do
            {
                Console.WriteLine(StartInfo);
                Console.WriteLine(VarInput);
                string varAnswer = Console.ReadLine();
                try
                {
                    if (varAnswer == "1")
                    {
                        while (true)
                        {
                            path = inputParameters(CountWordInput);
                            WordCounter wordCounter = new WordCounter(path[0], path[1]);
                            Console.WriteLine(string.Format(Answer, path[1], wordCounter.AmountOfCountWordInText));
                            break;
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            path = inputParameters(ChangeWordInput);
                            WordChange wordChange = new WordChange(path[0], path[1], path[2]);
                            Console.WriteLine(AnswerChange);
                            break;
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine(CountWordInput);
                }
                Console.WriteLine(StartAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }

        private static string[] inputParameters(string instructions)
        {
            string[] path;
            Console.WriteLine(instructions);
            path = Console.ReadLine().Split(' ');
            if (!File.Exists(path[0]))
                throw new FileNotFoundException();
            return path;
        }
    }
}
