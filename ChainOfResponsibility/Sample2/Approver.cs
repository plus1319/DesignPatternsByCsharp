using System;

namespace ChainOfResponsibility.Sample2
{
    abstract class Approver
    {
        protected Approver nextHandler;

        public void SetSuccessor(Approver successor)
        {
            this.nextHandler = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
    class Director : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else
            {
                nextHandler?.ProcessRequest(purchase);
            }
        }
    }
    class VicePresident : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else
            {
                nextHandler?.ProcessRequest(purchase);
            }
        }
    }
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else

            {
                Console.WriteLine(
                    "Request# {0} requires an executive meeting!",
                    purchase.Number);
            }
        }
    }

}