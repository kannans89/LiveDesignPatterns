using System;

class Program
{
    static void Main()
    {
        GumballMachine gumballMachine = new GumballMachine(5);

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        //Console.WriteLine(gumballMachine);

        //gumballMachine.InsertQuarter();
        //gumballMachine.TurnCrank();

        //gumballMachine.InsertQuarter();
        //gumballMachine.TurnCrank();
        //Console.WriteLine(gumballMachine);
    }
}
