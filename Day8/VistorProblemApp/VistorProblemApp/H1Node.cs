using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorProblemApp
{
    internal class H1Node : IHtmlNode
    {
        public void ExtractText()
        {
            Console.WriteLine("Extracting text form h1");
        }

        public void HighLightOperation()
        {
            Console.WriteLine("H1 tag is highlithted");
        }
    }
}
