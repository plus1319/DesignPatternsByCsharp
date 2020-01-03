using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Sample2
{
    public class BankAccount
   {
       private int _blance;

       public BankAccount(int blance)
       {
           _blance = blance;
       }

       public BankMemento Deposit(int amount)
       {
           _blance += amount;
           return new BankMemento(_blance);
       }

       public void Restore(BankMemento m)
       {
           _blance = m.Blance;
       }

       public override string ToString()
       {
           return $"{nameof(_blance)}:{_blance}";
       }
   }

}
