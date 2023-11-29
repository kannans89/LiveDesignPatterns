using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngineInterpreterApp
{
    public class TerminalExpression : IExpression
    {


        private String data;

        public TerminalExpression(String data)
        {
            this.data = data;
        }

        public bool Interpret(string input)
        {
            string[] tokens = input.Split(' ');

            foreach (string test in tokens)
            {
                if (test.Equals(data))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
