using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommandApp
{
    internal class WithdrawCommand : ICommand
    {

        private Account _account;
        private decimal _amount;

        public WithdrawCommand(Account acc, decimal amount)
        {

            _account = acc;
            _amount = amount;
        }
        public void Execute()
        {
            _account.Withdraw(_amount);
        }

        public void Undo()
        {
            _account.Deposit(_amount);
        }

    }
}
