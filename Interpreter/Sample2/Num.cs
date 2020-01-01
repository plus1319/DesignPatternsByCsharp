using System.Collections.Generic;

namespace Interpreter.Sample2
{
    public class Num : IExpression
    {
        private int _value;
        public Num(int value)
        {
            _value = value;
        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            return _value;
        }
    }
    
}