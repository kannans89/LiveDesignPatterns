using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngineInterpreterApp
{
    internal class OrExpression:IExpression
    {

        private IExpression _expressionLeft = null;
        private IExpression _expressionRight = null;

        public OrExpression(IExpression expression1, IExpression expresion2) { 
        
          _expressionLeft = expression1;
          _expressionRight = expresion2;
        }
        public bool Interpret(string context)
        {
           return _expressionLeft.Interpret(context)||
                _expressionRight.Interpret(context);
        }
    }
}
