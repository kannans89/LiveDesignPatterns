using AbstractFactoryCoreLib.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Factory
{
    public interface IAutoFacotry
    {

        public ICar MakeCar();//factory method1
        public ITruck MakeTruck();//factory method2
    }
}
