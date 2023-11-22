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
        private static AutomobileFactory _instance;
        public IAutoMobile Make(AutoType autotype)
        {
            //Violation of OCP

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

        private AutomobileFactory() {
            Console.WriteLine("Factory created");
        }
        public static AutomobileFactory GetInstance() { 
        
                if(_instance==null)
                _instance = new AutomobileFactory();

                return _instance;
        }

    }
}
