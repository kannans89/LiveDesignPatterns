using AccountDecoratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDecoratorApp.Decorator
{
    internal class AccountLoggingDecarator :AccountDecoratorBase
    {


        public AccountLoggingDecarator(IAccount account):base(account) { 
        }
       
        public override void Depsoit(double amt)
        {
            LogTimeofTransaction(amt,"deposit");
            _account.Depsoit(amt);
        }

        private void LogTimeofTransaction(double amt,string type)
        {
            Console.WriteLine($" Doing {type} and time of is {DateTime.UtcNow}");
        }

        public override void Withdraw(double amt)
        {
            LogTimeofTransaction(amt, "withdraw");
            _account.Withdraw(amt);
        }
    }
}
