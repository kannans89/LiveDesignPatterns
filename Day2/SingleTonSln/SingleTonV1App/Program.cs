namespace SingleTonV1App
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            var sv1 =  DataService.GetInstance();
            sv1.DoProcessing();

            var sv2 = DataService.GetInstance();
            sv2.DoProcessing();

            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());
        }
    }
}