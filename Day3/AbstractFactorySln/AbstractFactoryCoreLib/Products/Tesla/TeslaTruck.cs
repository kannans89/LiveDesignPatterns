using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Products.Tesla
{
    internal class TeslaTruck : ITruck
    {
        private int _cargoCapacity = 4000;//pounds
        public int CargoCapacity
        {
            get =>
             _cargoCapacity; set => _cargoCapacity = value;
        }

        public void LoadCargo()
        {
            Console.WriteLine("loading cargo of tesla truck");
        }

        public void Start()
        {
            Console.WriteLine("starting tesla truck");
        }

        public void Stop()
        {
            Console.WriteLine("stopping tesla truck");
        }
    }
   
}
