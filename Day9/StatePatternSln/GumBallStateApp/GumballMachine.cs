using GumBallStateApp;
// GumballMachine class
public class GumballMachine
{
    private IState soldOutState;
    private IState noQuarterState;
    private IState hasQuarterState;
    private IState soldState;

    private IState state;
    private int count;

    public GumballMachine(int numberGumballs)
    {
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);

        count = numberGumballs;
        if (numberGumballs > 0)
        {
            state = noQuarterState;
        }
        else
        {
            state = soldOutState;
        }
    }

    public void InsertQuarter()
    {
        state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        state.EjectQuarter();
    }

    public void TurnCrank()
    {
        state.TurnCrank();
        state.Dispense();
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (count > 0)
        {
            count--;
        }
    }

    public int Count => count;

    public void Refill(int count)
    {
        this.count += count;
        Console.WriteLine($"The gumball machine was just refilled; its new count is: {this.count}");
        state.Refill();
    }

    public void SetState(IState state)
    {
        this.state = state;
    }

    public IState GetState()
    {
        return state;
    }

    public IState GetSoldOutState()
    {
        return soldOutState;
    }

    public IState GetNoQuarterState()
    {
        return noQuarterState;
    }

    public IState GetHasQuarterState()
    {
        return hasQuarterState;
    }

    public IState GetSoldState()
    {
        return soldState;
    }

    public override string ToString()
    {
        return $"\nMighty Gumball," +
            $" Inc.\n C#-enabled Standing" +
            $" Gumball Model #2004\nInventory: {count} gumball{(count != 1 ? "s" : "")}\nMachine is {state}\n";
    }
}
