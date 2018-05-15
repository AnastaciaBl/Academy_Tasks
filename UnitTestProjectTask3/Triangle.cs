using System;

namespace Task3
{
    class Triangle:IComparable<Triangle>
    {
        public string Name { get; }
        private readonly double a;
        public readonly double b;
        public readonly double c;
        public double Area { get; }

        public Triangle(string name, double _a, double _b, double _c)
        {
            Name = name;
            a = _a;
            b = _b;
            c = _c;
            Area = findAreaOfTriangleByGeroneFormula();
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

        private double findAreaOfTriangleByGeroneFormula()
        {
            double p = 0.5 * (a + b + c);
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Math.Round(area, 2);
        }
    }
}
