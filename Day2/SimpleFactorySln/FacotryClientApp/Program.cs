using SimpleFactoryCoreLib;
using SimpleFactoryCoreLib.Product;

namespace FacotryClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            AutomobileFactory factory = new AutomobileFactory();
            IAutoMobile auto=   factory.Make(AutoType.BMW);
            Console.WriteLine(auto.GetType());
            auto.Start();
            auto.Stop();


        }
    }
}