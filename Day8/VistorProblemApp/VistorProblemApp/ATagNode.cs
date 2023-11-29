using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorProblemApp
{
    internal class ATagNode : IHtmlNode
    {
        public void HighLightOperation()
        {
            Console.WriteLine("Anchoar tag is highlted");
        }
        public void ExtractText()
        {
            Console.WriteLine("Extracting text form a tag");
        }
    }
}
