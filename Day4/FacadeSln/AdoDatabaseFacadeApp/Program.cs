namespace AdoDatabaseFacadeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            DbFacade facade = new DbFacade();

              facade.CreateTable();
            Console.WriteLine("Table created.");

            facade.InsertIntoTable();

            Console.WriteLine("Record inserted.");

            List<Address> addresses = facade.GetAddresses();

            foreach (Address address in addresses)
            {
                Console.WriteLine(address.Id + " " + address.StreetName + " " + address.City);
            }
        }

        private static void CaseStudy1()
        {
            var db = DbSingleton.Instance;
            var con1 = db.GetConnection();
            con1.Close();
            var con2 = db.GetConnection();

            Console.WriteLine(con1.GetHashCode());
            Console.WriteLine(con2.GetHashCode());
        }
    }
}