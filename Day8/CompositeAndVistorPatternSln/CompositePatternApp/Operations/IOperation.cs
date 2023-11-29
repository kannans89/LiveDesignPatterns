using CompositePatternApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp.Operations
{
    internal interface IOperation
    {
        void Apply(File file);
        void Apply(Folder folder);
    }
}
