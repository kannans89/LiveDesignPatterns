using AccountDecoratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDecoratorApp.Decorator
{
    internal abstract class AccountDecoratorBase : IAccount
    {
        protected IAccount _account;

        public AccountDecoratorBase(IAccount account)
        {
            _account = account;
        }
        public virtual int Accno => _account.Accno;

        public virtual double Balance => _account.Balance;

        public virtual string Name => _account.Name;

        public virtual void Depsoit(double amt)//can be override
        {
            _account.Depsoit(amt);
        }

        public abstract void Withdraw(double amt);//must override
       
    }
}
