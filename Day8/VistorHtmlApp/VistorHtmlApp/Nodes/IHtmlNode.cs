using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistorHtmlApp.Operations;

namespace VistorHtmlApp.Nodes
{
    internal interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
