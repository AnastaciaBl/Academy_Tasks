using System;
using System.IO;

namespace Task4
{
    class Program
    {
        private static string startInfo = "Task #4. File parser.";
        private static string varInput = "1 - count word\n2 - change word";
        private static string countWordInput = "Input <path to file> <word for count>, please.";
        private static string changeWordInput = "Input <path to file> <word for search> <word for change>, please.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string answer = "Amount of /{0}/ in the text: {1}";
        private static string answerChange = "File was changed.";

        static void Main(string[] args)
        {
            string endCheck = string.Empty;
            string[] path;
            do
            {
                Console.WriteLine(startInfo);
                Console.WriteLine(varInput);
                string varAnswer = Console.ReadLine();
                try
                {
                    if (varAnswer == "1")
                    {
                        while (true)
                        {
                            Console.WriteLine(countWordInput);
                            path = Console.ReadLine().Split(' ');
                            if (!File.Exists(path[0]))
                                throw new FileNotFoundException();
                            WordCounter wordCounter = new WordCounter(path[0], path[1]);
                            Console.WriteLine(string.Format(answer, path[1], wordCounter.AmountOfCountWordInText));
                            break;
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine(changeWordInput);
                            path = Console.ReadLine().Split(' ');
                            if (!File.Exists(path[0]))
                                throw new FileNotFoundException();
                            WordChange wordChange = new WordChange(path[0], path[1], path[2]);
                            Console.WriteLine(answerChange);
                            break;
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(countWordInput);
                }
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
