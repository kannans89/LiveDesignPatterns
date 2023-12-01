using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternConApp
{
    internal interface IConnectionState
    {
        public void Read();
        public void Write();

        public void ConfigureSecurity();
    }
}
