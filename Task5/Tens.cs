using System;

namespace Task5
{
    class Tens: IStringRepresentation
    {
        private string[] tens = new string[] { "", "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ",
            "семьдесят ", "восемьдесят ", "девяносто " };

        public string ReturnStringValue(string str)
        {
            string strValue = string.Empty;
            if (str[1] == '*')
                strValue = tens[0];
            else
                for (int i = 0; i < 10; i++)
                {
                    if ((int)Char.GetNumericValue(str[1]) == i)
                    {
                        strValue = tens[i];
                        break;
                    }
                }
            return strValue;
        }
    }
}
