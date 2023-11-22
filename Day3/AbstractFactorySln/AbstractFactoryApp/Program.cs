using AbstractFactoryCoreLib.Factory;
using AbstractFactoryCoreLib.Products;

namespace AbstractFactoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IAutoFacotry factory = new TeslaFactory();
            ITruck truck= factory.MakeTruck();
            truck.CargoCapacity = 2000;
            truck.Start();
            truck.Stop();
            Console.WriteLine(truck.CargoCapacity);

            ICar car = factory.MakeCar();
            car.Start();
            car.Stop();




        }
    }
}