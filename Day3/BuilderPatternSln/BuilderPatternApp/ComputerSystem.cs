using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp
{
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDD { get; set; }

        public string KeyBoard { get; set; }

        public string Mouse { get; set; }

        public string Processor { get; set; }


        public override string ToString()
        {
            return $"Ram is {RAM} hdd is {HDD}" +
                $" Keyboard is {KeyBoard} Mouse is {Mouse} " +
                $"Processor {Processor}";
        }
    }
}
