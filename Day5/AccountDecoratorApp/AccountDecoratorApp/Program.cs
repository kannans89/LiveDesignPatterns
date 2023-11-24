using AccountDecoratorApp.Decorator;
using AccountDecoratorApp.Model;

namespace AccountDecoratorApp
{


    class A
    {
        //public A() {
        //    Console.WriteLine("A");
        //}
        public int _data;
        public A(int a)
        {
            _data = a;
        }


    }

    class B : A
    {
        public B() : base(100)
        {
            Console.WriteLine("B");
        }

        public B(int d) : base(d)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            Console.WriteLine(b._data);

            var b2 = new B(200);
            Console.WriteLine(b2._data);

            //Withdraw or Deposit
            //LoggingDecoration
            //ValidationDecoration
            //LoggingDecorationAndValidationDecoration
            //ValidationAndLoggingAndAuthenticationDecoartion

            //  CaseStudy1();

            // CaseStudy2();

            var account = new Account(101, "abc", 1000);
            var validator = new AccountValidationDecorator(account);
            IAccount account1 = new AccountLoggingDecarator(validator);
            account1.Withdraw(999);
            Console.WriteLine(account1.Balance);
        }

        private static void CaseStudy2()
        {
            IAccount account1 = new AccountValidationDecorator(new Account(101, "abc", 1000));
            account1.Withdraw(999);
            Console.WriteLine(account1.Balance);
        }

        private static void CaseStudy1()
        {
            IAccount account1 = new AccountLoggingDecarator(new Account(101, "abc", 1000));
            account1.Withdraw(200);

            Console.WriteLine(account1.Balance);
        }
    }
}