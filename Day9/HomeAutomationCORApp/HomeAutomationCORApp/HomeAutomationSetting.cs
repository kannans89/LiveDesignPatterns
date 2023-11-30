using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationCORApp
{
    internal class HomeAutomationSetting
    {

        public bool LightsOff { get; set; }
        public bool LocksOn { get; set; }

        public bool AlarmsOn { get; set; }

        public HomeAutomationSetting()
        {

            LightsOff = true;
            LocksOn = true;
            AlarmsOn = true;
        }

    }
}
