using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacdePatternApp
{
    internal class OrderService
    {

        public bool HasEnoughOrders(int customerId)
        {
            // does the customer have enough orders?  
            // fake calculation for demo purposes
            return (customerId > 5);
        }
    }
}
