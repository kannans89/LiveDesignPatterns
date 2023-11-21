using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCoreLib.Product
{
    internal class Tesla:IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla stopping");
        }
    }
}
