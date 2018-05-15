using System;

namespace Task3
{
    static class CheckUserInput
    {
        public static bool IsCorrectSizeOfSides(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }
    }
}
