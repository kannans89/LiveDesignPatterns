namespace GumBallStateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            Console.WriteLine(gumballMachine);
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
        }
    }
}