using FactoryMethodCoreLib.Factory;
using FactoryMethodCoreLib.Product;
using Microsoft.Extensions.Configuration;

namespace FactoryMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IAutomobileFactory factory = new TeslaFactory();
            IAutoMobile auto = factory.Make();
            auto.Start();
            auto.Stop();


            //IAutomobileFactory factory = DoDependencyInjection();
            //IAutoMobile auto = factory.Make();
            //auto.Start();
            //auto.Stop();




        }

        private static IAutomobileFactory DoDependencyInjection()
        {
            //step 1 : need a configuration file
            //step 2: string type convert to C# type
            // step 3: Create instance

            IConfigurationRoot configuration = new ConfigurationBuilder()
                               
                                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                  .AddJsonFile(@"Config\config.json")
                                  .Build();

            string factoryName = configuration["FactoryName"];
            Console.WriteLine(factoryName);
            string assemblyName = "FactoryMethodCoreLib"; // Replace with the actual name of your assembly

            string typeName = factoryName + ", " + assemblyName;
            Type factoryType = Type.GetType(typeName);
            if (factoryType != null)
            {
                IAutomobileFactory factory = (IAutomobileFactory)Activator.CreateInstance(factoryType);

                return factory;
            }

            throw new Exception("invalid factory in config file");
        }
    }
}