using System;
using System.Collections.Generic;
using System.IO;

namespace Task6
{
    class Program
    {
        private static string startInfo = "Task #6. Find amount of happy tickets.";
        private static string wrongInputInfo = "It should be ****** number.";
        private static string numberInput = "Input a ****** ticket number, please.";
        private static string pathInput = "Input a path to file, please.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string inputAgain = "Do you want to input another number? y/n";
        private static string answer = "Amount of happy tickets: {0}";

        static void Main(string[] args)
        {
            string number, path, model, endCheck = string.Empty;
            do
            {
                string endInput = "y";
                ICount countModel = null;
                List<string> tickets = new List<string>();
                Console.WriteLine(startInfo);
                while (true && endInput.ToLower() == "y")
                {
                    Console.WriteLine(numberInput);
                    number = Console.ReadLine();
                    if (CheckUserInput.IsCorrectTicketNumber(number))
                    {
                        tickets.Add(number);
                        Console.WriteLine(inputAgain);
                        endInput = Console.ReadLine();
                    }
                    else Console.WriteLine(wrongInputInfo);
                }
                while(true)
                {
                    Console.WriteLine(pathInput);
                    path = Console.ReadLine();
                    try
                    {
                        using (StreamReader sr = new StreamReader(path))
                            model = sr.ReadLine();
                        if (model == "Moskow")
                        {
                            countModel = new MoskovCount();
                            break;
                        }
                        else if (model == "Piter")
                        {
                            countModel = new PiterCount();
                            break;
                        }
                        else throw new Exception("File does not consist useful information.");
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                HappyTickets happyTickets = new HappyTickets(tickets, countModel);
                Console.WriteLine(string.Format(answer, happyTickets.AmountOfHappyTickets));
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
