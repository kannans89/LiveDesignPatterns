using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp.Model.Compression
{
    internal interface ICompressionStrategy
    {
        void Compress(byte[] image);
    }
}
