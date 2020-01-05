using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample2
{
    public interface IElementVisitor
    {
        void Visit(Manager manager);
        void Visit(Employee manager);
    }
    class SalaryCalculator : IElementVisitor
    {
        public void Visit(Manager manager)
        {
            var salary = manager.WorkingHour * 10000;
            salary += manager.Wife * 25000;
            salary += manager.Children * 20000;
            salary -= manager.OffDays * 5000;
            Console.WriteLine("Manager's Salary is " + salary);
        }

        public void Visit(Employee employee)
        {
            var salary = employee.WorkingHour * 7000;
            salary += employee.Wife * 15000;
            salary += employee.Children * 10000;
            salary -= employee.OffDays * 6000;
            Console.WriteLine("Employee's Salary is " + salary);
        }

    }

    class WageCalculator : IElementVisitor
    {
        public void Visit(Manager manager)
        {
            var wage = manager.OverHours * 30000;
            Console.WriteLine("Employee's wage is " + wage);
        }

        public void Visit(Employee employee)
        {
            var wage = employee.OverHours * 20000;
            Console.WriteLine("Employee's wage is " + wage);
        }
    }
}
