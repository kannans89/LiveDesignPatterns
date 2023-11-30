using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationCORApp
{
    internal class LightCheckHandler : HomeAutomationHanlderBase
    {
        public override void Handle(HomeAutomationSetting status)
        {

            Console.WriteLine("checking for lights");
            if (status.LightsOff)
            {
                this.Next(status);

            }
            else
            {
                throw new Exception("Lights are on...Abort the mission");
            }

        }
    }
}
