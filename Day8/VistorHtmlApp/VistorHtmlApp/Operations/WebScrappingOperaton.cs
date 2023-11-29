using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistorHtmlApp.Nodes;

namespace VistorHtmlApp.Operations
{
    internal class WebScrappingOperaton : IOperation
    {
        public void Apply(H1Node node)
        {
            Console.WriteLine("webscriapping for h1");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("webscriapping for a1");
        }
    }
}
