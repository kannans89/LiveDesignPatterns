using ISPRefactoredApp.Model;

namespace ISPRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bot = new Robot();
            var manager = new Manager();
            AtTheWorkStation(manager);
            AtTheWorkStation(bot);

            AtTheCafeteria(manager);
          //  AtTheCafeteria(bot);
        }

        private static void AtTheCafeteria(IEatable eatable)
        {
            Console.WriteLine("At the Cafeteria");
            eatable.StartEat();
            eatable.StopEat();
            Console.WriteLine();
        }

        private static void AtTheWorkStation(IWorkable workable)
        {
            Console.WriteLine("At the Work Station");
            workable.StartWork();
            workable.StopWork();
            Console.WriteLine();
        }
    }
}