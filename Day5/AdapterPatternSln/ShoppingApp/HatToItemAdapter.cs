using ExternalFancyProductLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class HatToItemAdapter:Item
    {
        private Hat _hat;
        public HatToItemAdapter(Hat hat) { 
        
               _hat = hat;
        }

        public string ItemName()
        {
            return _hat.GetShortName();
        }

        public double ItemPrice()
        {
           return _hat.GetPrice();
        }
    }
}
