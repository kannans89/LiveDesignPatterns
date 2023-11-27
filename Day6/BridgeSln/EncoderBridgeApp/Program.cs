using EncoderBridgeApp.EncoderHierarchy;
using EncoderBridgeApp.Model;
using EncoderBridgeApp.SerializerHierarchy;

namespace EncoderBridgeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MovieData movie1 = new MovieData("1", "Summer blockbuster", 90);
            MovieData movie2 = new MovieData("2", "Generic romantic comedy", 72);

            var encoder = new  JsonEncoder();
            var serialzer = new FileMovieSerialzer(encoder,"c:\\temp");

            serialzer.WriteMovieDetails(movie1);
            serialzer.WriteMovieDetails(movie2);


        }
    }
}