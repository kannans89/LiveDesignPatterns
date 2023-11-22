using PrototypePatternApp.Model;
using System.Net.Http.Headers;

namespace PrototypePatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();

            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var r1 = new Rectangle { Color = "REd", Width = 100, Height = 20 };
            r1.Point = new Point { X=10,Y=20 };
            Console.WriteLine(r1.GetHashCode());

           var r2 =  (Rectangle) r1.Clone();

            Console.WriteLine(r2.GetHashCode());


            Console.WriteLine(r1.Point.GetHashCode());
            Console.WriteLine(r2.Point.GetHashCode());

            r1.Point.X = r1.Point.X + 100;

            Console.WriteLine(r2.Point.X);
            Console.WriteLine(r1.Point.X);
        }

        private static void CaseStudy1()
        {
            var r1 = new Rectangle { Color="REd",Width=100,Height=20 };
            Console.WriteLine(r1.GetHashCode());
            Console.WriteLine(r1.ToString());

            var r2 = (Rectangle) r1.Clone();

            Console.WriteLine(r2.GetHashCode());
            Console.WriteLine(r2.Width);
            Console.WriteLine(r2.ToString());

            r2.Color = "Blue";

            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}