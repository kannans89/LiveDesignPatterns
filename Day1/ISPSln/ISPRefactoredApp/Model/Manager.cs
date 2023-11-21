using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactoredApp.Model
{
    internal class Manager : IEatableWorkable
    {
        public void StartEat()
        {
            Console.WriteLine("Manager Starts eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager Starts Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager Stops eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager Stops Working");
        }
    }
}
