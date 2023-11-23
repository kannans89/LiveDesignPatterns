namespace AccountDecoratorApp.Model
{
    internal interface IAccount
    {
        int Accno { get; }
        double Balance { get; }
        string Name { get; }

        void Depsoit(double amt);
        void Withdraw(double amt);
    }
}