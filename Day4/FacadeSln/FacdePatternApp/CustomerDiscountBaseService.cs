using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacdePatternApp
{
    internal class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int customerId)
        {
            // fake calculation for POC
            return (customerId > 8) ? 10 : 20;
        }
    }
}
