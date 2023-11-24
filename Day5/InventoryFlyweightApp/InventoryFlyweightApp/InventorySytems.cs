using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryFlyweightApp
{
    public class InventorySystem
    {
        private readonly ItemCatalogFactory catalog = new ItemCatalogFactory();
        private readonly List<Order> orders = new List<Order>();

        public void TakeOrder(string itemName, int orderNumber)
        {
            ProductItemFlyweight item = catalog.MakeFlighWeight(itemName);
            Order order = new Order(orderNumber, item);
            orders.Add(order);
        }

        public void Process()
        {
            foreach (Order order in orders)
            {
                order.ProcessOrder();
            }
            orders.Clear();
        }

        public string Report()
        {
            return $"\nTotal Item objects made: {catalog.TotalItemsMade()}";
        }
    }
}
