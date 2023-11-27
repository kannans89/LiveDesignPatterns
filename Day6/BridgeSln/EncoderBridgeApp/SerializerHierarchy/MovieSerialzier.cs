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
        protected readonly IEncoder encoder;//bridge

        protected MovieSerializer(IEncoder encoder)
        {
            this.encoder = encoder ?? throw new ArgumentNullException(nameof(encoder));
        }

        public abstract void WriteEncodedMovieDetails(MovieData movieData);

       
    }
}
