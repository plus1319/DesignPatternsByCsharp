using System.Collections.Generic;

namespace Interpreter.Sample2
{
    public class Plus : IExpression
    {
        private IExpression _leftOperand;
        private IExpression _rightOperand;

        public Plus(IExpression leftOperand, IExpression rightOperand)
        {
            _leftOperand = leftOperand;
            _rightOperand = rightOperand;
        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            return _leftOperand.Interpret(context) + _rightOperand.Interpret(context);
        }
    }
    public class Minus : IExpression
    {
        private IExpression _leftOperand;
        private IExpression _rightOperand;

        public Minus(IExpression leftOperand, IExpression rightOperand)
        {
            _leftOperand = leftOperand;
            _rightOperand = rightOperand;
        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            return _leftOperand.Interpret(context) - _rightOperand.Interpret(context);
        }
    }
}