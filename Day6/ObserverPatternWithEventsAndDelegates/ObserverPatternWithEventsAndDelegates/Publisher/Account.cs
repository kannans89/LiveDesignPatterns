using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZObserverPatternWithEventsAndDelegates.Publisher
{
   // public delegate void BalanceChanged(Account acc);
    public class Account
    {

        private readonly int _accouno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        public event Action<Account> OnBalanceChanged=null;



        public Account(int accno, string name, double balance)
        {
            _balance = balance;
            _name = name;
            _accouno = accno;
           
          
        }

      


        public void Deposit(double amt) {
            _balance += amt;
            if(OnBalanceChanged!=null)
              OnBalanceChanged(this);




        }

        public void Withdraw(double amt)
        {
            _balance -= amt;
            if (OnBalanceChanged != null)
                OnBalanceChanged(this);
        }


        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public double Accouno
        {
            get
            {
                return _accouno;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
