namespace SingeltonV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            Task.Run(() =>
            {
                var sv1 = DataService.GetInstance();
                sv1.DoProcessing();

            });

            Task.Run(() =>
            {
                var sv1 = DataService.GetInstance();
                sv1.DoProcessing();

            });

            Console.WriteLine("end of main");

            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            var sv1 = DataService.GetInstance();
            sv1.DoProcessing();

            var sv2 = DataService.GetInstance();
            sv2.DoProcessing();

            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());

            Console.WriteLine(sv1 == sv2);
        }
    }
}