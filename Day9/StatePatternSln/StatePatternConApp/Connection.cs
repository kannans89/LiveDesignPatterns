using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternConApp
{
    public class Connection
    {
        private IConnectionState _state;
        public string ConnectionString { get; set; }

        public Connection(string connectionString)
        {
            this.ConnectionString = connectionString;
            this._state = new ClosedState(this);
        }
        public void Read() { 
         this._state.Read();
        }
        public void Write()
        {
            this._state.Write();
        }
        public void Close() {
            this._state = new ClosedState(this);
        }

        public void Open()
        {
            if (this._state is ClosedState)
            {
                this._state = new OpenState(this);
            }
        }

        public void Configure() {
            this._state.ConfigureSecurity();
        }


    }
}
