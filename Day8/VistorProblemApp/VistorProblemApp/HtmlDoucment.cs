using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorProblemApp
{
    internal class HtmlDoucment
    {
        private List<IHtmlNode> nodes;

        public HtmlDoucment() { 
        
        nodes = new List<IHtmlNode>(); 
        }
        public void Add(IHtmlNode node)
        {
            nodes.Add(node);

        }

        public void HightLight() {
        
            foreach (var node in nodes)
            {
                node.HighLightOperation();
            }
        }

        public void ExtractText() {
            foreach (var node in nodes)
            {
                node.ExtractText();
            }
        }
    }
}
