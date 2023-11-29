using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "I am the new person "+base.ToString();
        }
    }

    class AgeComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            // return x.Age - y.Age;

            // return y.Age - x.Age;
            return x.Age.CompareTo(y.Age);
        }
    }

    class NameComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            // return x.Age - y.Age;

            // return y.Age - x.Age;
            /// return x.Age.CompareTo(y.Age);
            /// 
           return x.Name.CompareTo(y.Name);
        }
    }


}
