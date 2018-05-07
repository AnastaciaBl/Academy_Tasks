using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        private static string startInfo = "Task #3. Find area of triangles.";
        private static string inputLine = "Input <triangle name> <A length> <B length> <C length> please.";
        private static string correctInput = "Input a right information, please.";
        private static string errorSides = "This triangle can`t exist.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string inputAgain = "Do you want to input another triangle? y/n";
        private static string answer = "Answer:";

        static void Main(string[] args)
        {
            string input = string.Empty, endCheck = string.Empty;
            do
            {
                string endInput = "y";
                List<Triangle> triangles = new List<Triangle>();
                Console.WriteLine(startInfo);
                while (true && (endInput.ToLower() == "y" || endInput.ToLower() == "yes"))
                {
                    Console.WriteLine(inputLine);
                    input = Console.ReadLine();
                    string[] partsOfStr = replaceSpaces(input);
                    if (partsOfStr.Length == 4)
                    {
                        try
                        {
                            if (CheckUserInput.IsCorrectSizeOfSides(Convert.ToDouble(partsOfStr[1]),
                                Convert.ToDouble(partsOfStr[2]), Convert.ToDouble(partsOfStr[3])))
                            {
                                triangles.Add(new Triangle(partsOfStr[0], Convert.ToDouble(partsOfStr[1]),
                                    Convert.ToDouble(partsOfStr[2]), Convert.ToDouble(partsOfStr[3])));
                                Console.WriteLine(inputAgain);
                                endInput = Console.ReadLine();
                            }
                            else Console.WriteLine(errorSides);
                        }
                        catch { Console.WriteLine(correctInput); }
                    }
                    else
                    {
                        Console.WriteLine(correctInput);
                    }
                }
                Console.WriteLine(answer);
                triangles.Sort();
                foreach (Triangle t in triangles)
                    Console.WriteLine(t.ToString());
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }

        private static string[] replaceSpaces(string line)
        {
            while (true)
            {
                if(line.Contains(","))
                    line = line.Replace(",", " ");
                else if (line.Contains("\t"))
                    line = line.Replace("\t", " ");
                else if (line.Contains("  "))
                    line = line.Replace("  ", " ");
                else
                {
                    line = line.TrimStart().TrimEnd();
                    return line.Split(' ');
                }
            }
        }
    }
}
