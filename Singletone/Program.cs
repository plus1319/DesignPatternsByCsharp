using System;
using System.Collections.Generic;
using System.Text;
using Singleton.Sample1;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //sample 1
            var instance1 = MathSingleton.GetInstance1;
            var instance2 = MathSingleton.GetInstance1;

            Console.WriteLine($"{(instance1 == instance2).ToString()}");

            var instance3 = MathSingleton.GetInstance2();
            var instance4 = MathSingleton.GetInstance2();
            Console.WriteLine($"{(instance3 == instance4).ToString()}");

            var instance5 = MathSingleton.GetInstance3;
            var instance6 = MathSingleton.GetInstance3;
            Console.WriteLine($"{(instance5 == instance6).ToString()}");

            var instance7 = MathSingleton.GetInstance4;
            var instance8 = MathSingleton.GetInstance4;
            Console.WriteLine($"{(instance7 == instance8).ToString()}");

            Console.ReadKey();

        }
    }
}
