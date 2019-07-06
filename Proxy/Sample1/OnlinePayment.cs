using System;

namespace Proxy.Sample1
{
   public class OnlinePayment
    {
        private IMoney _bankMoney;

        public OnlinePayment(IMoney money)
        {
            _bankMoney = money;
        }

        public void Pay(int amount)
        {
            //dagigan injast ke majbor shodim az proxy estefade konim
            //ye no ganon gozashtim
            if (CanPay(amount))
            {
                _bankMoney.Pay(amount);
            }
            else
            {
                Console.WriteLine("You can't pay more that 10000");
            }
        }

        private bool CanPay(int amount)
        {
            return amount < 10000 ? true : false;
        }
    }
}