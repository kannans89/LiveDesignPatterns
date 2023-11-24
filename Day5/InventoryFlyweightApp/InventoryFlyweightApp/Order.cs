using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryFlyweightApp
{
    internal class Order
    {
        private readonly int orderNumber;//extrensic
        private readonly ProductItemFlyweight item;//intincsic
        //common state

        public Order(int orderNumber, ProductItemFlyweight item)
        {
            this.orderNumber = orderNumber;
            this.item = item;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Ordering {item.ToString()} for order number {orderNumber}");
        }
    }
}
