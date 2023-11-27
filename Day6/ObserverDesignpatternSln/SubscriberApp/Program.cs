using PublisherLib.Model;
using SubscriberApp.Subscribers;

namespace SubscriberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new Account(1001, "Derek", 5000);
            account.AddSubscriber(new EmailNotificationSubscriber());
            account.AddSubscriber(new SmsNotificationSubscriber());
            account.Deposit(1000);
        }
    }
}