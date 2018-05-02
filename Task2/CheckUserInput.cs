using System;

namespace Task2
{
    static class CheckUserInput
    {
        public static bool IsDoubleNumber(string str)
        {
            try
            {
                double d = Convert.ToDouble(str);
                if (d > 0)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
