using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp.Model.Compression
{
    internal class PngCompressionStrategy : ICompressionStrategy
    {
        public void Compress(byte[] image)
        {
            Console.WriteLine("compression image to PNG format");
        }
    }
  
}
