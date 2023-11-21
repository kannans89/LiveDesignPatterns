using SimpleFactoryCoreLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCoreLib
{
    public enum AutoType
    {
        BMW, AUDI, TESLA
    }
    public class AutomobileFactory
    {

        public IAutoMobile Make(AutoType autotype)
        {

            if (autotype == AutoType.BMW)
            {

                return new Bmw();
            }
           else if (autotype == AutoType.TESLA)
            {

                return new Tesla();
            }
           
            else
                return new Audi();

        }

    }
}
