using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Products.Tesla
{
    internal class TeslaCar : ICar
    {
        private int _nofDoor = 2;
        public int NumberOfDoors
        {
            get => _nofDoor;

            set => _nofDoor = value;
        }

        public void Accelerate()
        {
            Console.WriteLine("Acceleration Tesla Sedan Car");
        }

        public void Start()
        {
            Console.WriteLine("starting Tesla Sedan Car");
        }

        public void Stop()
        {
            Console.WriteLine("stopping Tesla Sedan Car");
        }

    }
}
