using System.IO;

namespace Task4
{
    class FileParser
    {
        public string Path { get; private set; }
        public string Text { get; protected set; }

        protected FileParser(string path)
        {
            Path = path;
            Text = readFromFile();
        }
        
        private string readFromFile()
        {
            string text = string.Empty;
            using (StreamReader sr = new StreamReader(Path))
            {
                text = sr.ReadToEnd();
            }
            return text.ToLower();
        }
    }
}
