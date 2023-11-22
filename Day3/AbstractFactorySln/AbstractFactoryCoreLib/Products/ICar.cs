using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Products
{
    public interface ICar
    {

        void Start();

        void Stop();

        void Accelerate();
        int NumberOfDoors { get; set; }
    }
}
