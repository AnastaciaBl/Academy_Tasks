using System;

namespace Task6
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

        public static bool IsCorrectTicketNumber(string str)
        {
            if (str.Length != 6)
                return false;
            else
            {
                for(int i=0;i<str.Length;i++)
                {
                    if (!IsIntegerNumber(Convert.ToString(str[i])))
                        return false;
                }
            }
            return true;
        }
    }
}
