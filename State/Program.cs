using System;
using State.Sample1;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample1
            var tv = new Tv(Off.GetInstance);
            tv.toggleSwitch();
            tv.toggleSwitch();


            Console.ReadKey();
        }
    }
}
