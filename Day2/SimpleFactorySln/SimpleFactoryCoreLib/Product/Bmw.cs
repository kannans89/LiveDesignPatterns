using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCoreLib.Product
{
    internal class Bmw :IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("bmw starting");
        }

        public void Stop()
        {
            Console.WriteLine("bmw stopping");
        }
    }
}
