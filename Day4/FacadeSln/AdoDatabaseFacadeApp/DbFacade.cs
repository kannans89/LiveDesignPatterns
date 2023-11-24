using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdoDatabaseFacadeApp
{
    internal class DbFacade
    {
        private DbSingleton db = null;

        public DbFacade()
        {
            db = DbSingleton.Instance;
        }

        public int CreateTable()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CREATE TABLE Address (ID INT, StreetName NVARCHAR(20), City NVARCHAR(20))", conn))
                    {
                        count = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return count;
        }

        public int InsertIntoTable()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Address (ID, StreetName, City) VALUES (1, '1234 Some street', 'Madhurai')", conn))
                    {
                        count = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return count;
        }

        public List<Address> GetAddresses()
        {
            List<Address> addresses = new List<Address>();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Address", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                                Address address = new Address
                                {
                                    Id = reader[0].ToString(),
                                    StreetName = reader[1].ToString(),
                                    City = reader[2].ToString()
                                };

                                addresses.Add(address);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return addresses;
        }
    }
}
