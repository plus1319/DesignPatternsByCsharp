using System;
using Visitor.Sample1;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            Content content = new Content(50);
            Console.WriteLine($"element :{content.Data}");

            content.accept(new AddVisitor());
            Console.WriteLine($"add visitor:{content.Data}");

            content.accept(new MinusVisitor());
            Console.WriteLine($"minus visitor: {content.Data}");

            Console.ReadKey();
        }
    }
}
