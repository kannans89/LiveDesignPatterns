using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp
{
    public class ComputerSystemBuilder
    {
        private ComputerSystem _system;
        public ComputerSystemBuilder()
        {
            _system = new ComputerSystem();
        }
        public ComputerSystemBuilder AddKeyBoard(string keyBoard)
        {

            _system.KeyBoard = keyBoard;
            return this;
        }
        public ComputerSystemBuilder AddRAM(string ram)
        {

            _system.RAM = ram;
            return this;
        }

        public ComputerSystemBuilder AddHardDisk(string hdd)
        {

            _system.HDD = hdd;
            return this;
        }
        public ComputerSystemBuilder AddProcessor(string processor)
        {

            _system.Processor = processor;
            return this;
        }

        public ComputerSystemBuilder AddMouse(string mouse)
        {

            _system.Mouse = mouse;
            return this;
        }

        public ComputerSystem Build() { return _system; }

    }
}
