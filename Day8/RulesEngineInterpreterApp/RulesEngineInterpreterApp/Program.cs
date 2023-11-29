using RulesEngineInterpreterApp.Builder;

namespace RulesEngineInterpreterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy2();

            //K: Bears and (Lions or (Tigers and Bears))

            // String context = "Lions";
            // String context = "Tigers";
            // String context = "Bears";
            // String context = "Lions Tigers";
            //String context = "Lions Bears";
            // String context = "Tigers Bears";

            //IExpression define = buildInterperterTree();

            //Console.WriteLine(context + " is " + define.Interpret(context));

            // string context = "AgeAbove18";
            string context = "AgeAbove18 HasValidID";
            //string context = "AgeAbove18 IsVIP";
           // string context = "AgeAbove18 IsVIP HasValidID";

            IExpression define = new ExpressionBuilder()
                                .Terminal("AgeAbove18")
                                .And(andBuilder => andBuilder.Terminal("HasValidID")
                                .Or(orBuilder => orBuilder.Terminal("IsVIP")
                                .And(innerAndBuilder => innerAndBuilder.Terminal("HasSpecialAccess"))))
                                .Build();

            Console.WriteLine("Is the rule satisfied? " + define.Interpret(context));
        }

        private static IExpression buildInterperterTree()
        {

            //K: Bears and (Lions or (Tigers and Bears))

            IExpression terminal1 = new TerminalExpression("Lions");
            IExpression terminal2 = new TerminalExpression("Tigers");
            IExpression terminal3 = new TerminalExpression("Bears");

            // Tigers and Bears
            IExpression alternation1 = new AndExpression(terminal2, terminal3);

            //Lions or (Tigers and Bears)
            IExpression alternation2 = new OrExpression(terminal1, alternation1);

            //K: Bears and (Lions or (Tigers and Bears))
            return new AndExpression(terminal3, alternation2);

        }
        private static void CaseStudy2()
        {
            var context = "lion tiger bear";
            var t1 = new TerminalExpression("lion");
            // Console.WriteLine(t1.Interpret(context));

            var t2 = new TerminalExpression("tiger");

            //var orExpresion = new OrExpression(t1, t2);
            //Console.WriteLine(orExpresion.Interpret(context));

            var andExpression = new AndExpression(t1, t2);
            Console.WriteLine(andExpression.Interpret(context));
        }
    }
}