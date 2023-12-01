namespace GumBallStateApp
{
    // State interface
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Refill();
    }
}
