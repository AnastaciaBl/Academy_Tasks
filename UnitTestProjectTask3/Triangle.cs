using System;

namespace Task3
{
    class Triangle:IComparable<Triangle>
    {
        public string Name { get; private set; }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double Area { get; private set; }

        public Triangle(string name, double a, double b, double c)
        {
            Name = name;
            A = a;
            B = b;
            C = c;
            Area = findAreaOfTriangle();
        }

        public double findAreaOfTriangle()
        {
            double p = 0.5 * (A + B + C);
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Math.Round(area, 2);
        }

        public int CompareTo(Triangle other)
        {
            if (Area > other.Area)
                return 1;
            else if (Area < other.Area)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            string str = string.Format("[{0}]: {1} cm", Name, Area);
            return str;
        }
    }
}
