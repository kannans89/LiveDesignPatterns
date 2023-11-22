using System.Text;

namespace BuilderPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  CaseStudy1();

            CaseStudy2();
        }

        private static void CaseStudy2()
        {

            ComputerSystem system = new ComputerSystemBuilder()
                                     .AddProcessor("Intel")
                                     .AddKeyBoard("Logitech")
                                     .AddHardDisk("WD")
                                     .AddRAM("32GB")
                                     .AddMouse("Dell")
                                     .Build();

            Console.WriteLine(system.ToString());
        }

        private static void CaseStudy1()
        {
            string template = "<html>";
            //Console.WriteLine(template.GetHashCode());
            //template += "<body>";
            //Console.WriteLine(template.GetHashCode());

            //Console.WriteLine(template);

            StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb.GetHashCode());

            sb.Append("<html>")
              .Append("<body>")
              .Append("</body>")
              .Append("</html>");


            Console.WriteLine(sb.GetHashCode());

            string finalString = sb.ToString();
            Console.WriteLine(finalString);


        }
    }
}