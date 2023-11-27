using EncoderBridgeApp.Model;
using Newtonsoft.Json;
using System;

namespace EncoderBridgeApp.EncoderHierarchy
{
    public class JsonEncoder : IEncoder
    {
        public string Encode(MovieData movieData)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var writer = new JsonTextWriter(stringWriter))
                {
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartObject();
                    writer.WritePropertyName("Id");
                    writer.WriteValue(movieData.GetImdbId());

                    writer.WritePropertyName("Title");
                    writer.WriteValue(movieData.GetTitle());

                    writer.WritePropertyName("Length");
                    writer.WriteValue(movieData.GetLengthMin());

                    writer.WriteEndObject();
                }

                return stringWriter.ToString();
            }
        }
    }
}
