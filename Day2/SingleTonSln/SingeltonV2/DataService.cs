using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonV2
{
    internal class DataService
    {
        private static DataService _bucket = null;
        private static object _lock = new object();
        private DataService()
        {

            Console.WriteLine("Data Service Created");
        }


        public static DataService GetInstance()
        {

            lock (_lock)
            {
                if (_bucket == null)
                {
                    _bucket = new DataService();

                }

                return _bucket;
            }
        }

        public void DoProcessing()
        {

            Console.WriteLine("Processing done by " + this.GetHashCode());
        }
    }
}
