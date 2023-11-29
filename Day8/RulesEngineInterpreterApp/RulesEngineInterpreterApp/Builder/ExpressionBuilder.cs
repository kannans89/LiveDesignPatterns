using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngineInterpreterApp.Builder
{
    class ExpressionBuilder : IExpressionBuilder
    {
        private IExpression expression;

        public IExpressionBuilder Terminal(string value)
        {
            expression = new TerminalExpression(value);
            return this;
        }

        public IExpressionBuilder And(Action<IExpressionBuilder> buildExpression)
        {
            ExpressionBuilder subExpressionBuilder = new ExpressionBuilder();
            buildExpression(subExpressionBuilder);
            expression = new AndExpression(expression, subExpressionBuilder.Build());
            return this;
        }

        public IExpressionBuilder Or(Action<IExpressionBuilder> buildExpression)
        {
            ExpressionBuilder subExpressionBuilder = new ExpressionBuilder();
            buildExpression(subExpressionBuilder);
            expression = new OrExpression(expression, subExpressionBuilder.Build());
            return this;
        }

        public IExpression Build()
        {
            return expression;
        }


    }
}
