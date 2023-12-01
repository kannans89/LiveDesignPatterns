namespace StatePatternConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new Connection("ip=172.23.81.133;database=test");
            con.Open();
           // con.Open();
            con.Read();
            con.Configure();
            con.Close();
            con.Configure();
        }
    }
}