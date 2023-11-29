using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistorHtmlApp.Nodes;

namespace VistorHtmlApp.Operations
{
    internal interface IOperation
    {
        void Apply(H1Node node);
        void Apply(AnchorNode node);
        //25 oeverlods
    }
}
