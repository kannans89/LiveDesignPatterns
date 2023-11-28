using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediatorApp
{
    internal abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
        internal abstract void ReceiveNotification(Colleague colleague);

        public abstract string GetData();
        public abstract void SetData(string newData);
    }
}
