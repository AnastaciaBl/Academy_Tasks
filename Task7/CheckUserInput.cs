using System;

namespace Task7
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
    }
}
