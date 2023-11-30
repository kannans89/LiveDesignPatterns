using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionNoStatePatternApp
{
    internal enum ConnectionState
    {
        OPEN, CLOSE
    }
    internal class Connection
    {
        private ConnectionState _state;

        public Connection()
        {
            _state = ConnectionState.CLOSE;
        }

        public void Open()
        {
            _state = ConnectionState.OPEN;
        }
        public void Close()
        {
            _state = ConnectionState.CLOSE;
        }
        public void Read()
        {
            switch (_state)
            {

                case ConnectionState.CLOSE:
                    Console.WriteLine("connection closed,cannot initiate a reader object");
                    break;
                case ConnectionState.OPEN:
                    Console.WriteLine("Initiating a reader object");
                    break;
            }

        }
        public void Write()
        {
            switch (_state)
            {

                case ConnectionState.CLOSE:
                    Console.WriteLine("connection closed,cannot initiate a writer object");
                    break;
                case ConnectionState.OPEN:
                    Console.WriteLine("Initiating a writer object");
                    break;
            }
        }

        public void ConfigureSecurity()
        {

            switch (_state)
            {

                case ConnectionState.CLOSE:
                    Console.WriteLine("connection closed,cannot cannot configure security settings");
                    break;
                case ConnectionState.OPEN:
                    Console.WriteLine("Configuring security of connection");
                    break;
            }
        }
    }
}
