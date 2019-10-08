using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    abstract class AbstractExpression
    {
        public void Interpret(Context context)
        {
            if (context.input.Length == 0)
                return;

            if (context.input.StartsWith(nine))
            {
                context.output += (9 * multiplier);
                context.input = context.input.Substring(2);
            }
            else if (context.input.StartsWith(four))
            {
                context.output += (4 * multiplier);
                context.input = context.input.Substring(2);
            }
            else if (context.input.StartsWith(five))
            {
                context.output += (5 * multiplier);
                context.input = context.input.Substring(1);
            }

            while (context.input.StartsWith(one))
            {
                context.output += (1 * multiplier);
                context.input = context.input.Substring(1);
            }
        }

        public abstract string one { get; }
        public abstract string four { get; }
        public abstract string five { get; }
        public abstract string nine { get; }
        public abstract int multiplier { get; }

    }
}
