﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    internal class Manager : IWorker
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
