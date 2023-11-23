using FactoryMethodCoreLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public interface IAutomobileFactory
    {
        IAutoMobile Make();//Factory method

    }
}
