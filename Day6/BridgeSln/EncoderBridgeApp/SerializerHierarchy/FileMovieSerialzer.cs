using EncoderBridgeApp.EncoderHierarchy;
using EncoderBridgeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderBridgeApp.SerializerHierarchy
{
    public class FileMovieSerialzer:MovieSerializer
    {
        private readonly string rootDir;

        public FileMovieSerialzer(IEncoder encoder, string rootDir)
            : base(encoder)
        {
            this.rootDir = rootDir ?? throw new ArgumentNullException(nameof(rootDir));
        }

        public override void WriteEncodedMovieDetails(MovieData movieData)
        {
            string data= encoder.Encode(movieData);
            using (var output = new StreamWriter(Path.Combine(rootDir, $"movie_{movieData.GetImdbId()}.txt")))
            {
                output.Write(data);
            }
        }
    }
}
