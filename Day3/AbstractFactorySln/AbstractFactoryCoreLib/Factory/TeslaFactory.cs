using AbstractFactoryCoreLib.Products.Tesla;
using AbstractFactoryCoreLib.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Factory
{
    public class TeslaFactory : IAutoFacotry
    {
        public ICar MakeCar()
        {
            return new TeslaCar();
        }

        public ITruck MakeTruck()
        {
            return new TeslaTruck();
        }
    }

}
