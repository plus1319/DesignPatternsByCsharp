using System;
using NullObject.Sample1;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {

            //==================================================================
            //sample 1
            BankAccount ba = new BankAccount(NullLog.GetInstance);
            ba.Deposit(100);

            Console.ReadKey();
        }
    }
}
