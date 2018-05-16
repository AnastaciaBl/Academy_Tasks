using System;

namespace Task5
{
    class Units: IStringRepresentation
    {
        private string[] units = new string[] { "", "один ", "два ", "три ", "четыре ", "пять ", "шесть ",
            "семь ", "восемь ", "девять " };

        public string ReturnStringValue(string str)
        {
            string strValue = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                if ((int)Char.GetNumericValue(str[2]) == i)
                {
                    strValue = units[i];
                    break;
                }
            }
            return strValue;
        }
    }
}
