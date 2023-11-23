using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternApp.Model
{
    internal class Employee
    {

        //private List<Address> _address = null;
        public string Name { get; set; }

         public List<Address> Address { get; set; }

        public Employee() { 
          //_address = new List<Address>();

            Address = new List<Address>();
        }
        //public List<Address> Addresses{

        //    get { 
        //            return _address;
        //    }
        //    set { 
        //      _address = value;
        //    }
        // }

        public void AddAddress(Address address) { 
          _address.Add(address);
        }

    }
}
