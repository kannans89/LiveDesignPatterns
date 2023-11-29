using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp.Model.Filter
{
    internal class HighContrastFilterStrategy : IFilterStrategy
    {
        public void Apply(byte[] image)
        {
            Console.WriteLine("Applying HighContrast filter on image..");
        }
    }
    
}
