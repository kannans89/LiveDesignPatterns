using AccountCommandApp;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var acc1 = new Account("Satheesh", 1000);
            acc1.Deposit(2000);

            //snapshot and externalize

            FileStream fs = new FileStream(@"c:\temp\acc.bin",FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, acc1);
            fs.Close();
            Console.WriteLine("object serialzed");

        }
    }
}