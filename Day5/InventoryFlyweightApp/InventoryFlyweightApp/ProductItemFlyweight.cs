using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryFlyweightApp
{
    internal class ProductItemFlyweight
    {
        private String name;
        private String category;
        private byte[] picture;

        public ProductItemFlyweight(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
