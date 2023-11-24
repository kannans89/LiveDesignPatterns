using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp
{
    public class Document : IDocument
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int AuthorId { get; private set; }
        public DateTimeOffset LastAccessed { get; private set; }
      
        private string _fileName;

        public Document(string fileName)
        {
            _fileName = fileName;
            LoadDocument(fileName);
            Console.WriteLine("document created");
        }

        private void LoadDocument(string fileName)
        {
            Console.WriteLine("Executing expensive action: loading a file " + fileName + " from disk");
            

            Task.Delay(2000).Wait();

            Title = " expensive document  Tiltle loaded";
            Content = "Expensive couments content loaded";
            AuthorId = 1;
            LastAccessed = DateTimeOffset.UtcNow;
        }

        public void DisplayDocument()
        {
            Console.WriteLine("diplaying conents of " + _fileName);
            Console.WriteLine($" Title: {Title}, Content: {Content}");
        }
    }
}
