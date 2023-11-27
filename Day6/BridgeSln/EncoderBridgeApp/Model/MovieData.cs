using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderBridgeApp.Model
{
    public class MovieData
    {

        private readonly string id;
        private readonly string title;
        private readonly uint length;

        public MovieData(string id, string title, uint length)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.length = length;
        }

        public string GetImdbId() => id;
        public string GetTitle() => title;
        public uint GetLengthMin() => length;
    }


}
