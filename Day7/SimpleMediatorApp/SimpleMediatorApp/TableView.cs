using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediatorApp
{
    internal class TableView : Colleague
    {
        private string _data;

        public TableView(Mediator mediator):base(mediator) { 
        
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
            if(this!=updatedColleague)
            {
                _data = updatedColleague.GetData();
            }

            Console.WriteLine("ReceiveNotification method of table view "+_data);
        }
    }
}
