using AccountCommandApp;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\temp\acc.bin", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
           Account account= (Account)binaryFormatter.Deserialize(fs);
            Console.WriteLine( account.Name);
            Console.WriteLine(account.Balance);

            fs.Close();
        }
    }
}