using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngineInterpreterApp
{
    public interface IExpression
    {
        public bool Interpret(String context);
    }
}
