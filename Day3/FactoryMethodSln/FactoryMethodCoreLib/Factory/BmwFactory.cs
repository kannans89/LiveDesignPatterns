using FactoryMethodCoreLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class BmwFactory : IAutomobileFactory
    {
        public IAutoMobile Make()
        {
           return new Bmw();
        }
    }
}
