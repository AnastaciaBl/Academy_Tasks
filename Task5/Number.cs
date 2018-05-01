using System.Collections.Generic;

namespace Task5
{
    class Number
    {
        public string InputNumber { get; private set; }
        public string ResultNumber { get; private set; }
        private List<string> partsOfNumber;

        public Number(string number)
        {
            InputNumber = number;
            partsOfNumber = separateNumberOnTriplets();
            ResultNumber = CreateResultNumber();
        }

        public string CreateResultNumber()
        {
            string result = string.Empty;
            if (InputNumber == "0")
                result = "ноль";
            else
            {
                for(int i=0;i<partsOfNumber.Count;i++)
                {
                    ICreateStringRepresentation[] stringRepresent = new ICreateStringRepresentation[]
                    {
                        new Hundreds(),
                        new Tens(),
                        new Units()
                    };
                    for (int j = 0; j < stringRepresent.Length; j++)
                        result += stringRepresent[j].ReturnStringValue(partsOfNumber[i]);
                }
            }
            return result;
        }

        public override string ToString()
        {
            return ResultNumber;
        }

        private List<string> separateNumberOnTriplets()
        {
            List<string> partsOfNumber = new List<string>();
            int amountOfTriplets = InputNumber.Length / 3;
            int residual = InputNumber.Length - amountOfTriplets * 3;
            if(residual != 0)
                partsOfNumber.Add(createResidualTriplets(residual));
            for (int i= residual; i< InputNumber.Length;)
            {
                string temp = string.Empty;
                for (int j = 0; j < 3; j++)
                {
                    temp += InputNumber[i];
                    i++;
                }
                partsOfNumber.Add(temp);
            }
            return partsOfNumber;
        }

        private string createResidualTriplets(int residual)
        {
            string temp = string.Empty;
            for (int i = 0; i < 3 - residual; i++)
                temp += "*";
            for (int i = 0; i < residual; i++)
                temp += InputNumber[i];
            return temp;
        }
    }
}
