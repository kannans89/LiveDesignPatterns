using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleMediatorApp
{
    internal class GridView : Colleague
    {
        private string _data;

        public GridView(Mediator mediator) : base(mediator)
        {

        }
        public override string GetData()
        {
            return _data;
        }

        public override void SetData(string newData)
        {
            _data = newData;
            _mediator.Notify(this);
        }

        internal override void ReceiveNotification(Colleague updatedColleague)
        {
            if (this != updatedColleague)
            {
                _data = updatedColleague.GetData();
            }

            Console.WriteLine("ReceiveNotification method of Grid view " + _data);
        }
    }

}
