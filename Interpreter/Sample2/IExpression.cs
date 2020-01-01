using System.Collections.Generic;

namespace Interpreter.Sample2
{
    public interface IExpression
    {
        int Interpret(Dictionary<string, IExpression> context);
    }
}