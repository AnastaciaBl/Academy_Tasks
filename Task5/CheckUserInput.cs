using System;

namespace Task5
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
                if (d >= 0 && d <= 999)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
