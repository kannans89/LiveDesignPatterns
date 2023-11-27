using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Model
{
    public class Account
    {

        private readonly int _accouno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private List<IAccountNotificationSubscriber> _subscribers;


        public Account(int accno, string name, double balance)
        {
            _balance = balance;
            _name = name;
            _accouno = accno;
            _subscribers = new List<IAccountNotificationSubscriber>();
          
        }

        public void AddSubscriber(IAccountNotificationSubscriber subscriber) { 
          _subscribers.Add(subscriber);
        }


        public void Deposit(double amt) {
            _balance += amt;


            foreach(IAccountNotificationSubscriber subscriber in _subscribers)
            {
                subscriber.BalanceChanged(this);

            }
        }

        public void Withdraw(double amt)
        {
            _balance -= amt;

            foreach (IAccountNotificationSubscriber subscriber in _subscribers)
            {
                subscriber.BalanceChanged(this);

            }
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
