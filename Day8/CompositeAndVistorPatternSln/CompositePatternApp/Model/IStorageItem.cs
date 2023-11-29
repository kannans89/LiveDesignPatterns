using CompositePatternApp.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp.Model
{
    internal interface IStorageItem
    {
        void Display(int depth=0);
        void Execute(IOperation operation);
    }
}
