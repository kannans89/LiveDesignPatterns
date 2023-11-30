using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMementoApp
{
    internal class EmployeeMemento
    {
        private readonly string name;
        private readonly string phone;

        public EmployeeMemento(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public string GetName()
        {
            return name;
        }

        public string GetPhone()
        {
            return phone;
        }

    }
}
