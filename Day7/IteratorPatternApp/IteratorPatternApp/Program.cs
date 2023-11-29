using System.Collections;
using System.Linq;
namespace IteratorPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            // CaseSTudy2();

            // CaseStudy3();

            IEnumerable repo2 = new NamesRepository("Kannan,Satheesh,Derek,Gordan");
            var query =repo2.Cast<object>().ToList()
                .OrderByDescending(x => x);

            foreach (var item in query)
            {

                Console.WriteLine(item);
            }
                


        }

        private static void CaseStudy3()
        {
            var repo = new NamesRepository("Kannan,Satheesh,Derek,Gordan");
            repo.AddName("Pradhibha");




            foreach (var item in repo)
            {

                Console.WriteLine(item);
            }
        }

        private static void CaseSTudy2()
        {
            var repo = new NamesRepository("Kannan,Satheesh,Derek,Gordan");
            repo.AddName("Pradhibha");

            var namesEnumertor = repo.MakeEnumerator();

            Console.WriteLine(namesEnumertor.GetType());

            while (namesEnumertor.MoveNext())
            {
                Console.WriteLine(namesEnumertor.Current.ToString().ToUpper());

            }
        }

        private static void CaseStudy1()
        {

            var arr = new int[] { 10, 20 };

            Console.WriteLine(arr.GetEnumerator().GetType());

            var arrEnumerator = arr.GetEnumerator();
            while (arrEnumerator.MoveNext())
            {
                Console.WriteLine(arrEnumerator.Current);

            }


            var list = new List<int>();
            Console.WriteLine(list.GetEnumerator().GetType());

            var set = new HashSet<int>();
            Console.WriteLine(set.GetEnumerator().GetType()) ;

            

        }
    }
}