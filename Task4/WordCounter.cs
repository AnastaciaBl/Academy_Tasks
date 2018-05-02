namespace Task4
{
    class WordCounter:FileParser
    {
        public string CountWord { get; private set; }
        public int AmountOfCountWordInText { get; private set; }

        public WordCounter(string path, string wordForCount):base(path)
        {
            CountWord = wordForCount.ToLower();
            AmountOfCountWordInText = findAmountOfCountWord();
        }

        private int findAmountOfCountWord()
        {
            int x = -1;
            int counter = 0;
            while (x < Text.Length)
            {
                x = Text.IndexOf(CountWord, x + 1);
                if (x == -1)
                    break;
                else
                    counter++;
            }
            return counter;
        }
    }
}
