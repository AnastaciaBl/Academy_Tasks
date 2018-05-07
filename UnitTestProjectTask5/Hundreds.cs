using System;

namespace Task5
{
    class Hundreds: ICreateStringRepresentation
    {
        private string[] hundreds = new string[] { "", "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ",
            "семьсот ", "восемьсот ", "девятьсот " };

        public string ReturnStringValue(string str)
        {
            string strValue = string.Empty;
            if (str[0] == '*')
                strValue = hundreds[0];
            else
                for(int i=0;i<10;i++)
                {
                    if ((int)Char.GetNumericValue(str[0]) == i)
                    {
                        strValue = hundreds[i];
                        break;
                    }
                }
            return strValue;
        }
    }
}
