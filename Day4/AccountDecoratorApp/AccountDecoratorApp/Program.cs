using AccountDecoratorApp.Model;

namespace AccountDecoratorApp
{

    class Man {
        public   void Play() {
            Console.WriteLine(  "Man is playing");
        }
    }

    class Boy:Man {
        //public override  void Play()
        //{
        //    Console.WriteLine("boy is playing");
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // //Man x; // x expects a man or subclass of man
            //Man x = new Boy();
            //x.Play();

            //var account1 = new( new Account(101, "abc", 1000));
            account1.Depsoit(200);

            Console.WriteLine(account1.Balance);


        }
    }
}