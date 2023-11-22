using AbstractFactoryCoreLib.Products.BMW;
using AbstractFactoryCoreLib.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Factory
{
    public class BmwFactory : IAutoFacotry
    {
        public ICar MakeCar()
        {
            return new BmwCar();
        }

        public ITruck MakeTruck()
        {
            return new BmwTruck();
        }
    }
}
