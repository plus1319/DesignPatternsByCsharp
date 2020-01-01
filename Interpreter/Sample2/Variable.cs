using System.Collections.Generic;

namespace Interpreter.Sample2
{
    public class Variable : IExpression
    {
        private string _value;
        public Variable(string value)
        {
            _value = value;
        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            if (context.ContainsKey(_value) == null) return 0;
            return context[_value].Interpret(context);
        }
    }
}