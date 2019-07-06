using System;
using Proxy.Sample1;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            Console.WriteLine("---------- Proxy example");
            var payment = new OnlinePayment(new CashPayment());
            payment.Pay(200000);
            payment.Pay(1000);

        }
    }
}
