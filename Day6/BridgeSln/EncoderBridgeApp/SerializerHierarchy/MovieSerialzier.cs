using EncoderBridgeApp.EncoderHierarchy;
using EncoderBridgeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderBridgeApp.SerializerHierarchy
{
    public abstract class MovieSerializer
    {
        private readonly IEncoder encoder;//bridge

        protected MovieSerializer(IEncoder encoder)
        {
            this.encoder = encoder ?? throw new ArgumentNullException(nameof(encoder));
        }

        protected abstract void WriteEncodedMovieDetails(MovieData movieData, string data);

        public void WriteMovieDetails(MovieData movieData)//template method
        {
            var encodedString = encoder.Encode(movieData);
            WriteEncodedMovieDetails(movieData, encodedString);
        }
    }
}
