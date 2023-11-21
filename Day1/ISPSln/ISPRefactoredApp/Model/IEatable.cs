using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactoredApp.Model
{
    internal interface IEatable
    {
        void StartEat();
        void StopEat();
    }
}
