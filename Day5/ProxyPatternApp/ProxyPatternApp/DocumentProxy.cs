using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp
{
    internal class DocumentProxy : IDocument
    {

        private Document _document;
        private string _fileName;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;

            // complete code here ...

        }

        public void DisplayDocument()
        {
            
            if (_document == null)
            {
                _document = new Document(_fileName);
            }
            _document.DisplayDocument();
        }
    }
}
