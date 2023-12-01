using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternConApp
{
    internal class ClosedState : IConnectionState
    {
        private Connection _connection;

        public ClosedState(Connection connection) { 
          _connection = connection;
        }

        public void ConfigureSecurity()
        {
            Console.WriteLine(_connection.ConnectionString + "state is closed");
        }

        public void Read()
        {
            Console.WriteLine(_connection.ConnectionString+ "state is closed");
        }

        public void Write()
        {
            Console.WriteLine(_connection.ConnectionString + "state is closed");
        }
    }
}
