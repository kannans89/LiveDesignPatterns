using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp.Model.Compression
{
    internal class JpegCompressionStrategy : ICompressionStrategy
    {
        public void Compress(byte[] image)
        {
            Console.WriteLine("compression image to jpeg format");
        }
    }
}
