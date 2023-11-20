using SRPRefactorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Presentation
{
    internal class InvoiceHtmlPrinter
    {
        public void PrintToHtml(Invoice invoice)
        {


            string template = $"Id :{invoice.Id} " +
                $",description:{invoice.Description}" +
                $" cost is :{invoice.Cost}" +
                $" tax amt is :{invoice.CalculateTax()}" +
                $" discount amt is {invoice.CalculateDiscount()}" +
                $" Final cost is :{invoice.FinalCost()}";


            StreamWriter sw = new StreamWriter(invoice.Id + ".html");
            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1>");
            sw.WriteLine(template);
            sw.WriteLine("</h1>");
            sw.WriteLine("</body>");

            sw.WriteLine("</html>");
            sw.Close();



        }
    }
}
