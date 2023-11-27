using System.ComponentModel;
using XYZObserverPatternWithEventsAndDelegates.Publisher;

namespace ObserverPatternWithEventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(101, "Derek", 1000);

            account.OnBalanceChanged += EmailNotification;
            account.OnBalanceChanged += SmsNotfication;
          //  account.OnBalanceChanged += Foo;
            account.Deposit(100);


            // DMathOperation x = Add;
            Action<int, int> x = Add; 
            x(10, 20);
            x = Sub;
            x(30, 40) ;


        }
       // delegate void DMathOperation(int x, int y);

        static void Add(int x, int y) { 
        
        }
       static void Sub(int x, int y)
        {

        }

        void Foo() { 
        
        }
        private static void EmailNotification(Account acc)
        {
            Console.WriteLine("Email send to accoun holder "+acc.Name+ "balancie is"+acc.Balance);
        }

        private static void SmsNotfication(Account acc)
        {

            Console.WriteLine("sms send to accoun holder " + acc.Name + "balancie is" + acc.Balance);
        }
    }
}