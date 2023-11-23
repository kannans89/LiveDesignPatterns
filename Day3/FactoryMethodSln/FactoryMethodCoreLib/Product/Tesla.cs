﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Product
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
