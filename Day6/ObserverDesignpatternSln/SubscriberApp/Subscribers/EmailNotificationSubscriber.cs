using PublisherLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberApp.Subscribers
{
    internal class EmailNotificationSubscriber : IAccountNotificationSubscriber
    {
        public void BalanceChanged(Account account)
        {
            Console.WriteLine("EMAIL notification send to "
                + account.Name + " lates balance is" + account.Balance);
        }
    }
}
