namespace VistorProblemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var doc = new HtmlDoucment();
            doc.Add(new H1Node());
            doc.Add(new ATagNode());
            doc.HightLight();
            doc.ExtractText();


        }
    }
}