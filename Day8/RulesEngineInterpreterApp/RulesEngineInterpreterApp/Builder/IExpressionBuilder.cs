using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngineInterpreterApp.Builder
{
    interface IExpressionBuilder
    {
        IExpressionBuilder Terminal(string value);
        IExpressionBuilder And(Action<IExpressionBuilder> expression);
        IExpressionBuilder Or(Action<IExpressionBuilder> expression);
        IExpression Build();
    }
}
