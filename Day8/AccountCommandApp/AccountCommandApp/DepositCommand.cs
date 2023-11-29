using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommandApp
{
    internal class DepositCommand : ICommand
    {
        private Account _account;
        private decimal _amount;

        public DepositCommand(Account acc,decimal amount) { 
        
          _account = acc;
            _amount = amount;
        }
        public void Execute()
        {
            _account.Deposit(_amount);
        }

        public void Undo()
        {
            _account.Withdraw(_amount);
        }
    }
}
