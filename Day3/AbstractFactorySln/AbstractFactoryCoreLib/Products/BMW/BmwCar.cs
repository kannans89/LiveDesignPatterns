using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Products.BMW
{
    internal class BmwCar : ICar
    {
        private int _nofDoor = 4;
        public int NumberOfDoors { get => _nofDoor; 
            
            set => _nofDoor=value; }

        public void Accelerate()
        {
            Console.WriteLine("Acceleration BMW Sedan Car");
        }

        public void Start()
        {
            Console.WriteLine("starting BMW Sedan Car");
        }

        public void Stop()
        {
            Console.WriteLine("stopping BMW Sedan Car");
        }
    }
}
