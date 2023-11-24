using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDecoratorApp.Model
{
    internal class Account : IAccount
    {
        private int _accno;
        private string _name;
        private double _balance;

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }
        public void Depsoit(double amt)
        {
            _balance += amt;
        }

        public void Withdraw(double amt)
        {
           
            _balance -= amt;
        }

        public int Accno { get { return _accno; } }

        public string Name { get { return _name; } }

        public double Balance { get { return _balance; } }

    }
}
