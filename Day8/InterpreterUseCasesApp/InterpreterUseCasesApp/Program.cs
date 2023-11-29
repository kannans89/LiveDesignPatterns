using System.Text.RegularExpressions;

namespace InterpreterUseCasesApp
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            //CaseSTudy2();

            var students = new[]
        {
            new Student { Name = "Alice", Age = 22 },
            new Student { Name = "Bob", Age = 19 },
            new Student { Name = "Charlie", Age = 25 }
        };

            IQueryable<Student> query1 = students.AsQueryable()
                                               .Where(x => x.Name == "Alice");
                                               

        

            foreach (Student student in query1)
            {

                Console.WriteLine(student.Name);
            }


        }

        private static void CaseSTudy2()
        {
            var students = new[]
          {
            new Student { Name = "Alice", Age = 22 },
            new Student { Name = "Bob", Age = 19 },
            new Student { Name = "Charlie", Age = 25 }
        };

            IEnumerable<Student> query1 = students
                                      .Where(s => s.Age > 22);
            foreach (Student student in query1)
            {
                Console.WriteLine(student.Name);
            }
        }

        private static void CaseStudy1()
        {
            //sentence
            string input = "Lions, and tigers, and bears! Oh, my!";

            //expression tree, builda a grammar(rule engine)
            Regex regex = new Regex("(lion|cat|dog|wolf|bear|human|tiger|liger|Lion)");

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {

                Console.WriteLine("Found a " + match.Value);
            }
        }
    }
}