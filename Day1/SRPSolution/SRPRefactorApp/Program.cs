
using SRPRefactorApp.Model;
using SRPRefactorApp.Presentation;

Invoice invoice = new Invoice(1, "Training Invoice", 100, .50);

InvoiceConsolePrinter printer = new InvoiceConsolePrinter();
printer.PrintInvoice(invoice);

InvoiceHtmlPrinter htmlPrinter = new InvoiceHtmlPrinter();
htmlPrinter.PrintToHtml(invoice);

Console.WriteLine("end");