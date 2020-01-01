 using System;
using System.Collections.Generic;
using Interpreter.Sample1;
using Interpreter.Sample2;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 2
            //string expression = "w x z - +";
            //var sentence = new Evaluator(expression);

            //Dictionary<string, IExpression> variables =
            //    new Dictionary<string, IExpression>()
            //    {
            //        {"w",new Num(5)},
            //        {"x",new Num(10)},
            //        {"z",new Num(42)}
            //    };

            //int result = sentence.Interpret(variables);
            //Console.WriteLine(result);
            //sample 1
            var context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };
            var expression = new NonTerminalExpression();
            expression.Interpret(context);
            Console.WriteLine(context.Result);

            Console.ReadKey();
        }
    }
}
