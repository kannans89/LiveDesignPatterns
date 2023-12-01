namespace StateMotivation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new Connection();
            con.Open();
            con.Read();
            con.ConfigureSecurity();
        }
    }
}