using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp.Model.Filter
{
    internal interface IFilterStrategy
    {
        void Apply(byte[] image);
    }
}
