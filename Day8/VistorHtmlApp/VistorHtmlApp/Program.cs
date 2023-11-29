using VistorHtmlApp.Nodes;
using VistorHtmlApp.Operations;

namespace VistorHtmlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDoucment();
            document.Add(new H1Node());
            document.Add(new AnchorNode());

            document.Execute(new WebScrappingOperaton());
        }
    }
}