using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommandApp
{
    internal class Scheduler
    {
        public List<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand command) { 
            _commands.Add(command);
        }

        public void ExecuteAll() { 
            foreach (ICommand command in _commands)
            {
                command.Execute();

            }
        }

        public void UndoAll() { 
         
            for(var i=_commands.Count-1; i>=0; i--)
            {
                _commands[i].Undo();

            }
        
        }
    }
}
