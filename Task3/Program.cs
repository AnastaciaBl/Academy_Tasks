using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        private const string StartInfo = "Task #3. Find area of triangles.";
        private const string InputLine = "Input <triangle name> <A length> <B length> <C length> please.";
        private const string CorrectInput = "Input a right information, please.";
        private const string ErrorSides = "This triangle can`t exist.";
        private const string StartAgain = "Do you want to start a program again? y/n";
        private const string InputAgain = "Do you want to input another triangle? y/n";
        private const string Answer = "Answer:";

        static void Main(string[] args)
        {
            string input = string.Empty, endCheck = string.Empty;
            do
            {
                string endInput = "y";
                List<Triangle> triangles = new List<Triangle>();
                Console.WriteLine(StartInfo);
                while (true && (endInput.ToLower() == "y" || endInput.ToLower() == "yes"))
                {
                    double a = 0, b = 0, c = 0;
                    Console.WriteLine(InputLine);
                    input = Console.ReadLine();
                    string[] partsOfStr = replaceSpaces(input);
                    if (partsOfStr.Length == 4)
                    {
                        if (IsAllSidesNumbers(partsOfStr, ref a, ref b, ref c))
                            if (CheckUserInput.IsCorrectSizeOfSides(a, b, c))
                                triangles.Add(new Triangle(partsOfStr[0], a, b, c));
                            else Console.WriteLine(ErrorSides);
                        else Console.WriteLine(CorrectInput);
                        Console.WriteLine(InputAgain);
                        endInput = Console.ReadLine();
                    }
                }
                Console.WriteLine(Answer);
                triangles.Sort();
                foreach (Triangle t in triangles)
                    Console.WriteLine(t.ToString());
                Console.WriteLine(StartAgain);
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

        private static bool IsAllSidesNumbers(string[] partsOfStr, ref double a, ref double b, ref double c)
        {
            if (Double.TryParse(partsOfStr[1], out a) && Double.TryParse(partsOfStr[2], out b) &&
                Double.TryParse(partsOfStr[3], out c))
                return true;
            else return false;
        }
    }
}
