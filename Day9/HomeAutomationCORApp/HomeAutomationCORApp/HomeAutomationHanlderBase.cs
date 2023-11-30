using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationCORApp
{
    internal abstract class HomeAutomationHanlderBase
    {
        private HomeAutomationHanlderBase _next;

        public abstract void Handle(HomeAutomationSetting status);

        public void SucceedWith(HomeAutomationHanlderBase nextInChain)
        {
           _next = nextInChain;

        }
        protected void Next(HomeAutomationSetting dto)
        {
            if (this._next != null)
            {
                this._next.Handle(dto);
            }
        }

    }
}
