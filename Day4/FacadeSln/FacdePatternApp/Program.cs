using System.Collections;

namespace FacdePatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            // CaseStudy2();

            CaseStudy3();

            Console.ReadLine();

        }

        private static void CaseStudy3()
        {
            var names = new string[] { "abc", "pqr", "lmno" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //IEnumerator stringEnumerator= names.GetEnumerator();

            // while(stringEnumerator.MoveNext())
            // {

            //     Console.WriteLine(stringEnumerator.Current);
            // }
        }

        private async static void CaseStudy2()
        {
            var httpclient = new HttpClient();
            string url = "http://numbersapi.com/12";
            var response = await httpclient.GetAsync(url);
            string content= await  response.Content.ReadAsStringAsync();

            Console.WriteLine(content);

        }

        private static void CaseStudy1()
        {
            var facade = new DisocuntFacade();
            Console.WriteLine(facade.CalculateDiscountPercentage(201));
            Console.WriteLine(facade.CalculateDiscountPercentage(3));
        }
    }
}