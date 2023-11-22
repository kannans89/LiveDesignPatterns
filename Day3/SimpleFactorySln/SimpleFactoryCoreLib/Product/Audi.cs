using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCoreLib.Product
{
    internal class Audi : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi stopping");
        }
   
    
    }
}
