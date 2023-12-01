namespace SimpleMVCCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Use(async (context, next) => {

                Console.WriteLine("Use3 middleware before(B)");
                await next();
                Console.WriteLine("Use3 middleware after(A)");
            });


            app.Use(async (context, next) => {

                Console.WriteLine("Use1 middleware before(B)");
                await next();
                Console.WriteLine("Use1 middleware after(A)");
            });
            app.Use(async (context, next) => {

                Console.WriteLine("Use2 middleware before(B)");
                await next();
                Console.WriteLine("Use2 middleware after(A)");
            });

         

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}