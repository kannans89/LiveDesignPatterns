using SimpleFactoryCoreLib;
using SimpleFactoryCoreLib.Product;

namespace FacotryClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            AutomobileFactory factory = AutomobileFactory.GetInstance();
            IAutoMobile auto=   factory.Make(AutoType.BMW);
            Console.WriteLine(auto.GetType());
            auto.Start();
            auto.Stop();


            AutomobileFactory factory2 = AutomobileFactory.GetInstance();
            IAutoMobile auto2 = factory.Make(AutoType.TESLA);
            Console.WriteLine(auto2.GetType());
            auto2.Start();
            auto2.Stop();

            Console.WriteLine(factory==factory2);

        }
    }
}