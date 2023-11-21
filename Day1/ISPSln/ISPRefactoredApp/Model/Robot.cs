using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactoredApp.Model
{
    internal class Robot : IWorkable
    {
       
        public void StartWork()
        {
            Console.WriteLine("Robot Starts Working");
        }
              

        public void StopWork()
        {
            Console.WriteLine("Robot Stops Working");
        }
    }
}
