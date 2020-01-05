using System;
using Visitor.Sample1;
using Visitor.Sample2;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 2
            IElement manager = new Manager();
            IElement employee = new Employee();

            //------------------------------------
            //instead of this codes we make class like FinancialSystem 

            //var salary = new SalaryCalculator();
            //manager.Accept(salary);
            //employee.Accept(salary);


            //var wage = new WageCalculator();
            //manager.Accept(wage);
            //employee.Accept(wage);
            //------------------------------------
            var fine = new FinancialSystem();
            fine.Attach(manager);
            fine.Attach(employee);

            fine.Accept(new SalaryCalculator());
            fine.Accept(new WageCalculator());


            //======================================================================

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
