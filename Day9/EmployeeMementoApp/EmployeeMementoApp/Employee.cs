using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMementoApp
{
    internal class Employee
    {
        private String name;
        private String address;
        private String phone;

        public Employee(String name, String address, String phone)
        {
            this.Name = name;
            this.address = address;
            this.Phone = phone;

        }

        public EmployeeMemento Save()
        {//serialize
            return new EmployeeMemento(this.name, this.phone);
        }

        public void Revert(EmployeeMemento memento)//deserialization
        {
            this.name = memento.GetName();
            this.phone = memento.GetPhone();
        }


        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

    }
}

