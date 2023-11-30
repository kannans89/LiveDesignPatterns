using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMementoApp
{
    internal class CareTaker
    {
        private Stack<EmployeeMemento> _employeeHistory =
            new Stack<EmployeeMemento>();


        public void Save(Employee employee) {
            _employeeHistory.Push(employee.Save());
        }

        public void Revert(Employee employee)
        {

            var lastMemento =  _employeeHistory.Pop();
            employee.Revert(lastMemento);
        }

    }
}
