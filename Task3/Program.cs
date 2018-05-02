using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        private static string startInfo = "Task #3. Find area of triangles.";
        private static string nameInput = "Input a triangle`s name, please.";
        private static string numberInput = "Input {0} triangle`s side, please.";
        private static string errorSides = "This triangle can`t exist.";
        private static string startAgain = "Do you want to start a program again? y/n";
        private static string inputAgain = "Do you want to input another triangle? y/n";
        private static string answer = "Answer:";

        static void Main(string[] args)
        {
            string a, b, c, name = string.Empty, endCheck = string.Empty;
            do
            {
                string endInput = "y";
                List<Triangle> triangles = new List<Triangle>();
                Console.WriteLine(startInfo);
                while (true && (endInput.ToLower() == "y" || endInput.ToLower() == "yes"))
                {
                    Console.WriteLine(nameInput);
                    name = Console.ReadLine();
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
                    while (true)
                    {
                        c = inputSide("B");
                        if (CheckUserInput.IsDoubleNumber(c))
                            break;
                    }
                    if (CheckUserInput.IsCorrectSizeOfSides(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)))
                    {
                        triangles.Add(new Triangle(name, Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)));
                        Console.WriteLine(inputAgain);
                        endInput = Console.ReadLine();
                    }
                    else Console.WriteLine(errorSides);
                }
                Console.WriteLine(answer);
                triangles.Sort();
                foreach (Triangle t in triangles)
                    Console.WriteLine(t.ToString());
                Console.WriteLine(startAgain);
                endCheck = Console.ReadLine();
            } while (endCheck.ToLower() == "y");
        }

        private static string inputSide(string nameOfSide)
        {
            Console.WriteLine(numberInput, nameOfSide);
            return Console.ReadLine();
        }
    }
}
