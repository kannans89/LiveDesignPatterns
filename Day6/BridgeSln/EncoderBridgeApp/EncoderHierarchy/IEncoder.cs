using EncoderBridgeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderBridgeApp.EncoderHierarchy
{
    public interface IEncoder
    {
        public  string Encode(MovieData movieData);
    }
}
