using EncoderBridgeApp.EncoderHierarchy;
using EncoderBridgeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderBridgeApp.SerializerHierarchy
{
    internal class ConsoleMovieSerializer:MovieSerializer
    {
        public ConsoleMovieSerializer(IEncoder encoder)
               : base(encoder)
        {
        }

        public override void WriteEncodedMovieDetails(MovieData movieData)
        {
            string data = encoder.Encode(movieData);
            Console.WriteLine("displaying details of:".ToUpper() + movieData.GetImdbId());
            Console.WriteLine(data);
        }
    }
}
