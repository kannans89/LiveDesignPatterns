using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediatorApp
{
    internal class Mediator
    {
        private List<Colleague> _collegs = new List<Colleague>();

        public void Add(Colleague colleague)
        {
            _collegs.Add(colleague);
        }
        public void Notify(Colleague updatedColleague)
        {
            foreach (var coll in _collegs)
            {

                coll.ReceiveNotification(updatedColleague);
            }
        }
    }
}
