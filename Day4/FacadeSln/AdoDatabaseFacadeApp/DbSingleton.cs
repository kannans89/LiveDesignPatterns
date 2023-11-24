using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDatabaseFacadeApp
{
    public sealed class DbSingleton
    {
        private static DbSingleton instance = null;
        private static readonly object lockObject = new object();
        private SqlConnection conn = null;

        private DbSingleton()
        {

        }

        public static DbSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new DbSingleton();
                        }
                    }
                }

                return instance;
            }
        }

        public SqlConnection GetConnection()
        {
            if (conn == null || conn.State == ConnectionState.Closed)
            {
                lock (lockObject)
                {
                    if (conn == null || conn.State == ConnectionState.Closed)
                    {
                        try
                        {
                            string dbConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyOrgnization;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
                            conn = new SqlConnection(dbConnectionString);
                            conn.Open();
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
            }

            return conn;
        }
    }
}
