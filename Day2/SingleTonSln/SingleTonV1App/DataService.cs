using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonV1App
{
    internal class DataService
    {
        private static DataService  _bucket=null;
        private DataService() {

            Console.WriteLine("Data Service Created");
        }


        public static DataService GetInstance() {

            if (_bucket == null)
            {
                _bucket = new DataService();
            
            }

            return _bucket;
        }

        public void DoProcessing() {

            Console.WriteLine("Processing done by "+this.GetHashCode());
        }
    }
}
