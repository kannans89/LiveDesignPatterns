using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryFlyweightApp
{
    internal class ItemCatalogFactory
    {
        private readonly Dictionary<string, ProductItemFlyweight> items = new ();

        public ProductItemFlyweight MakeFlighWeight(string itemName)
        {
            if (!items.ContainsKey(itemName))
                items[itemName] = new ProductItemFlyweight(itemName);

            return items[itemName];
        }

        public int TotalItemsMade()
        {
            return items.Count;
        }
    }
}
