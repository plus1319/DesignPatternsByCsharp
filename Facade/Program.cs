using System;
using Facade.Sample1;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // just like service layer in web application
            //sample 1
            CalculationFacade facade = new CalculationFacade();

            Console.WriteLine(facade.Calculate(20));


            Console.ReadKey();
        }
    }
}
