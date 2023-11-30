using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationCORApp
{
    internal class LockCheckHandler : HomeAutomationHanlderBase
    {
        public override void Handle(HomeAutomationSetting status)
        {

            Console.WriteLine("checking for Locks");
            if (status.LocksOn)
            {
                this.Next(status);

            }
            else
            {
                throw new Exception("Locks are not on...Abort the mission");
            }

        }
    }
}
