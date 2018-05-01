using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] triangles = new Triangle[]
            {
                new Triangle("New1", 8,7,6),
                new Triangle("New2", 3,5,4),
                new Triangle("New3", 2,2,3),
            };
            Array.Sort(triangles);
            foreach (Triangle t in triangles)
                Console.WriteLine(t.ToString());
            Console.ReadLine();
        }
    }
}
