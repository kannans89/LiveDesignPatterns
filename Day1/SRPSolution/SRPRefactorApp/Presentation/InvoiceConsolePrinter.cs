using SRPRefactorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Presentation
{
    internal class InvoiceConsolePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id :{invoice.Id} " +
                $",description:{invoice.Description}" +
                $" cost is :{invoice.Cost}" +
                $" tax amt is :{invoice.CalculateTax()}" +
                $" discount amt is {invoice.CalculateDiscount()}" +
                $" Final cost is :{invoice.FinalCost()}";
            Console.WriteLine(template);
            Console.ResetColor();


        }
    }
}
