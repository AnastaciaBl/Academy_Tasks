using System;

namespace Task8
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
    }
}
