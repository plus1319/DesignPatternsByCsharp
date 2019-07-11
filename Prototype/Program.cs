using System;
using Prototype.Sample1;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            var branch1 = new BankBranch("1", "branch1");
            Console.WriteLine($"code:{branch1.Code} , manager name{branch1.ManagerName}");

            var branch2 = branch1.Clone();
            Console.WriteLine($"code:{branch2.Code} , manager name{branch2.ManagerName}");

            branch2.Code = "2";
            branch2.ManagerName = "branch2";

            Console.WriteLine($"code:{branch1.Code} , manager name{branch1.ManagerName}");

            Console.WriteLine($"code:{branch2.Code} , manager name{branch2.ManagerName}");

            Console.ReadKey();
        }
    }
}
