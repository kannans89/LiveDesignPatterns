using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class ShoppingCart
    {
        private List<Item> _items = new List<Item>();

        public void Add(Item item)
        {

            _items.Add(item);

        }
        public double Total
        {
            get
            {
                double sum = 0;
                foreach (Item item in _items)
                {
                    sum += item.ItemPrice();

                }
                return sum;
            }
        }

        public List<Item> Items {
            get { 
              return _items;
            }
        }
    }
}
