using System;

namespace Task3
{
    static class CheckUserInput
    {
        public static bool IsDoubleNumber(string str)
        {
            try
            {
                double d = Convert.ToDouble(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsIntegerNumber(string str)
        {
            try
            {
                double d = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsCorrectSizeOfSides(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }
    }
}
