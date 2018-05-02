using System;

namespace Task1
{
    static class CheckUserInput
    {
        public static bool IsIntegerNumber(string str)
        {
            try
            {
                double d = Convert.ToInt32(str);
                if (d > 0)
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
