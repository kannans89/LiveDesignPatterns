using AccountDecoratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDecoratorApp.Decorator
{
    internal class AccountValidationDecorator : AccountDecoratorBase
    {
    

     
        public AccountValidationDecorator(IAccount account):base(account)
        {

            Console.WriteLine("AccountValidationDecorator");

        }
       

        public override void Depsoit(double amt)
        {
            CheckInputIsPositive(amt);
            _account.Depsoit(amt);
        }

        private void CheckInputIsPositive(double amt)
        {
            if (amt < 0) {
                throw new ApplicationException("Negative values supplied");
            }
        }

        public override void Withdraw(double amt)
        {
            CheckInputIsPositive(amt);
            if (_account.Balance - amt <= 0) {
                throw new ApplicationException("Balance cannot be zero or negative");
            }
            _account.Withdraw(amt);
        }
    }
}
