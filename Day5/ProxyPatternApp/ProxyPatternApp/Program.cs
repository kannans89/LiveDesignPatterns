namespace ProxyPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();

            // CaseStudy2();

            var doc1 = new ProtectedDocumentProxy("doc1.pdf", "Viewer123");
            doc1.DisplayDocument();
        }

        private static void CaseStudy2()
        {
            var doc1 = new DocumentProxy("doc1.pdf");
            var doc2 = new DocumentProxy("doc2.pdf");
            var doc3 = new DocumentProxy("doc3.pdf");

            doc3.DisplayDocument();
            doc3.DisplayDocument();
        }

        private static void CaseStudy1()
        {
            var doc1 = new Document("doc1.pdf");
            var doc2 = new Document("doc2.pdf");
            var doc3 = new Document("doc3.pdf");

            doc3.DisplayDocument();
        }
    }
}