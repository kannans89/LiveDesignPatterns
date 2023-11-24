using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Book : Item
    {
        public string ItemName()
        {
            return "C# ";
        }

        public double ItemPrice()
        {
            return 10;
        }
    }
}
