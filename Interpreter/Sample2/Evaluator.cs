using System.Collections.Generic;

namespace Interpreter.Sample2
{
    public class Evaluator : IExpression
    {
        private IExpression syntaxTree;

        public Evaluator(string expression)
        {
            Stack<IExpression> expressionStack = new Stack<IExpression>();
            foreach (var token in expression.Split(" "))
            {
                switch (token)
                {
                    case "+":
                        IExpression addExpression =
                            new Plus(expressionStack.Pop(),expressionStack.Pop());
                        expressionStack.Push(addExpression);
                        break;
                    case "-":
                        IExpression right = expressionStack.Pop();
                        IExpression left = expressionStack.Pop();
                        IExpression subExpression = new Minus(left,right);
                        expressionStack.Push(subExpression);
                        break;
                    default:
                        expressionStack.Push(new Variable(token));
                        break;
                }

            }
            syntaxTree = expressionStack.Pop();

        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            return syntaxTree.Interpret(context);
        }
    }
}