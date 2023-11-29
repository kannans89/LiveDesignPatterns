using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistorHtmlApp.Nodes;
using VistorHtmlApp.Operations;

namespace VistorHtmlApp
{
    internal class HtmlDoucment
    {
        private List<IHtmlNode> nodes;

        public HtmlDoucment()
        {

            nodes = new List<IHtmlNode>();
        }
        public void Add(IHtmlNode node)
        {
            nodes.Add(node);

        }

        public void Execute(IOperation operation)
        {

            foreach (IHtmlNode node in nodes)
            {
                node.Execute(operation);
            }
        }

    }
}
