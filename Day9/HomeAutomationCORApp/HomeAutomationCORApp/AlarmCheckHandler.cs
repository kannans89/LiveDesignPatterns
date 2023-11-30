using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationCORApp
{
    internal class AlaramCheckHandler : HomeAutomationHanlderBase
    {
        public override void Handle(HomeAutomationSetting status)
        {

            Console.WriteLine("checking for Alarms");
            if (status.AlarmsOn)
            {
                this.Next(status);

            }
            else
            {
                throw new Exception("Alarms are not on...Abort the mission");
            }

        }
    }
}
