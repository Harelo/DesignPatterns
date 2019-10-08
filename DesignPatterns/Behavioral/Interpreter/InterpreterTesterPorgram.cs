using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    public class InterpreterTesterPorgram
    {
        public static void RunTest()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<AbstractExpression> expressions = new List<AbstractExpression>();
            expressions.Add(new ThousandExpression());
            expressions.Add(new HundredExpression());
            expressions.Add(new TenExpression());
            expressions.Add(new OneExpression());

            foreach (AbstractExpression e in expressions)
                e.Interpret(context);

            Console.WriteLine($"{roman} = {context.output}");
        }
    }
}
