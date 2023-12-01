
// SoldState class
using GumBallStateApp;

public class SoldState : IState
{
    private readonly GumballMachine gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
    }

    public void Dispense()
    {
        gumballMachine.ReleaseBall();
        if (gumballMachine.Count > 0)
        {
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }
    }

    public void Refill() { }

    public override string ToString()
    {
        return "dispensing a gumball";
    }
}
