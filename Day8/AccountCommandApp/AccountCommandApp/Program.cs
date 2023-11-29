namespace AccountCommandApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account("kannan", 600);

            var cmdDeposit1 = new DepositCommand(account1, 1000);
            var cmdDeposit2 = new DepositCommand(account1, 500);

            Scheduler scheduler = new Scheduler();
            scheduler.Add(cmdDeposit1);
            scheduler.Add(cmdDeposit2);

            scheduler.ExecuteAll();

            PrintDetails(account1);

            scheduler.UndoAll();
            PrintDetails(account1 );

        }
        private static void PrintDetails(Account account)
        {
            Console.WriteLine($"Name is {account.Name} balance is {account.Balance}");
        }
    }
}