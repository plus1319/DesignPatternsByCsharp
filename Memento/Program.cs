using System;
using Memento.Sample1;
using Memento.Sample2;
using Memento.Sample3;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 3
            var ba = new BankAccount2(100);
            var m1 = ba.Deposit(50); //150
            var m2 = ba.Deposit(25); //175
            Console.WriteLine(ba);

            ba.Undo(); //150
            ba.Undo(); //100
            Console.WriteLine(ba);

            ba.Redo(); //150
            Console.WriteLine(ba);
        
            //=====================================================================

            //sample 2
            //var ba = new BankAccount(100);
            //var m1 = ba.Deposit(50); //150
            //var m2 = ba.Deposit(25); //175
            //Console.WriteLine(ba);

            //ba.Restore(m1); //150
            //Console.WriteLine(ba);

            //ba.Restore(m2); //175
            //Console.WriteLine(ba);

            //=====================================================================

            //sample 1
            //var editor = new Editor();
            //editor.Type("this is 1");
            //editor.Type("this is 2");
            //Console.WriteLine(editor.Content);
            //editor.Save();

            //editor.Type("this is 3");
            //Console.WriteLine(editor.Content);

            //editor.Restore();
            //Console.WriteLine(editor.Content);

            Console.ReadKey();
        }
    }
}
