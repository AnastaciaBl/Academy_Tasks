using System;
using System.Collections.Generic;
using System.IO;

namespace Task6
{
    class Program
    {
        private const string StartInfo = "Task #6. Find amount of happy tickets.";
        private const string WrongInputInfo = "It should be ****** number.";
        private const string NumberInput = "Input a ****** ticket number, please.";
        private const string PathInput = "Input a path to file, please.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string InputAgain = "Do you want to input another number? y/n";
        private const string Answer = "Amount of happy tickets: {0}";

        static void Main(string[] args)
        {
            string number, path, model, endCheck = string.Empty;
            do
            {
                string endInput = "y";
                IHappyTicketCounter countModel = null;
                Console.WriteLine(StartInfo);
                while(true)
                {
                    Console.WriteLine(PathInput);
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
                HappyTickets happyTickets = new HappyTickets(countModel);
                Console.WriteLine(string.Format(Answer, happyTickets.AmountOfHappyTickets));
                Console.WriteLine(StartAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }
    }
}
