using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Products.BMW
{
    internal class BmwTruck : ITruck
    {
        private int _cargoCapacity = 3000;//pounds
        public int CargoCapacity { get => 
             _cargoCapacity; set => _cargoCapacity=value; }

        public void LoadCargo()
        {
            Console.WriteLine("loading cargo of bmw truck");
        }

        public void Start()
        {
            Console.WriteLine("starting bmw truck");
        }

        public void Stop()
        {
            Console.WriteLine("stopping bmw truck");
        }
    }
}
