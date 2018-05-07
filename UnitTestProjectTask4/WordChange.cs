using System.IO;

namespace Task4
{
    class WordChange:FileParser
    {
        public string OldWord { get; private set; }
        public string NewWord { get; private set; }

        public WordChange(string path, string oldWord, string newWord):base(path)
        {
            OldWord = oldWord.ToLower();
            NewWord = newWord;
            changeText();
        }

        private void changeText()
        {
            Text = Text.Replace(OldWord, NewWord);
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(Text);
            }
        }
    }
}
