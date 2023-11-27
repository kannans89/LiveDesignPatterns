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

        protected override void WriteEncodedMovieDetails(MovieData movieData, string data)
        {
            Console.WriteLine("displaying details of:".ToUpper() + movieData.GetImdbId());
            Console.WriteLine(data);
        }
    }
}
