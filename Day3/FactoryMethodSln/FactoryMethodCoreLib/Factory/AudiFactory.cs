using FactoryMethodCoreLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class AudiFactory : IAutomobileFactory
    {
        public IAutoMobile Make()
        {
            return new Audi();
        }


    }
}
