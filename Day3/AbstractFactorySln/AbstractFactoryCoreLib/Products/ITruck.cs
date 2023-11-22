using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCoreLib.Products
{
    public interface ITruck
    {
        void Start();

        void Stop();

        void LoadCargo();

        int CargoCapacity { get; set; }
    }
}
