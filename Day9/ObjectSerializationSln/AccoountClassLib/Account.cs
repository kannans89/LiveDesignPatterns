using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommandApp
{

    class TestClass : Attribute { 
    
    }

    [Serializable] //Attribute
   
    public class Account 
    {
        public string Name { get; set; }
        public decimal Balance { get; private set; }

        public Account(string name, decimal balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public void Deposit(decimal amt)
        {
            this.Balance += amt;
        }


        public void Withdraw(decimal amt)
        {
            if (Balance - amt > 500)
            {
                this.Balance -= amt;
                return;
            }

            throw new Exception("no sufficient funds");
        }

        
    }
}
