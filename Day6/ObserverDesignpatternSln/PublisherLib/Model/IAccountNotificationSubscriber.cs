using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Model
{
    public interface IAccountNotificationSubscriber
    {
        void BalanceChanged(Account account);
    }
}
