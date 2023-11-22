using MySql.Data.MySqlClient;
using System.Data.Common;

namespace AdoFactoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Choose the database provider (e.g., SQL Server)
            // string providerName = "System.Data.SqlClient";
            string providerName = "MySql.Data.MySqlClient";
            //  DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory(providerName, MySqlClientFactory.Instance);

            // Get the factory for the chosen provider
            DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);

            Console.WriteLine(factory.GetType());

            // Create a connection using the factory
            using (DbConnection connection = factory.CreateConnection())
            {
                Console.WriteLine(connection.GetType());
                if (connection != null)
                {
                    // Set the connection string
                    // connection.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyOrgnization;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
                    connection.ConnectionString = "Server=localhost;Database=springv2;User ID=root;Password=root;";
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute a query using the connection
                        using (DbCommand command = connection.CreateCommand())
                        {
                            Console.WriteLine(command.GetType());
                            command.CommandText = "SELECT * FROM Organizations";
                            using (DbDataReader reader = command.ExecuteReader())
                            {
                                // Process the results
                                while (reader.Read())
                                {
                                    // Do something with the data
                                    Console.WriteLine(reader["Name"]);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Failed to create a connection.");
                }
            }
        }
    }

}