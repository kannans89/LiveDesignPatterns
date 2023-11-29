using StrategyDesignPaternApp.Model;
using StrategyDesignPaternApp.Model.Compression;
using StrategyDesignPaternApp.Model.Filter;

namespace StrategyDesignPaternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var store = new ImageStore(new PngCompressionStrategy(), new HighContrastFilterStrategy());
            // store.Store();


            //CaseStudy2();

            var p1 = new Person { Name = "Alice", Age = 30 };
            Console.WriteLine(p1);
            Console.WriteLine(p1.ToString());
        }

        private static void CaseStudy2()
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

            people.Sort(new NameComparer());
            //var sortedPeople = people
            //                .OrderBy(p => p.Age);
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }
        }
    }
}