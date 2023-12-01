using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternConApp
{
    internal class OpenState : IConnectionState
    {
        private Connection _connection;

        public OpenState(Connection connection) { 
         _connection = connection;
        }

        public void ConfigureSecurity()
        {
            Console.WriteLine("configuring security for "+_connection.ConnectionString);
        }

        public void Read()
        {
            Console.WriteLine("Reading data using "+_connection.ConnectionString);
        }

        public void Write()
        {
            Console.WriteLine("writing data using " + _connection.ConnectionString);
        }
    }
}
