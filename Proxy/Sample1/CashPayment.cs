using System;

namespace Proxy.Sample1
{
    class CashPayment : IMoney
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"You payed {amount} ");
        }
    }
}