using EncoderBridgeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderBridgeApp.EncoderHierarchy
{
    public class PlainTextEncoder : IEncoder
    {
        public string Encode(MovieData movieData)
        {
            var sstream = new StringWriter();
            sstream.WriteLine($"Id: {movieData.GetImdbId()}");
            sstream.WriteLine($"Title: {movieData.GetTitle()}");
            sstream.WriteLine($"Length: {movieData.GetLengthMin()}\n");

            return sstream.ToString();
        }
    }
}
