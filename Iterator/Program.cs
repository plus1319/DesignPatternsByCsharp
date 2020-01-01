using System;
using Iterator.Sample1.Aggregate;
using Iterator.Sample1.Iterator;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            //------------------------------------------
            Console.WriteLine("Facebook::");
            PrintUsers(fbIterator);

            Console.WriteLine("Twitter::");
            PrintUsers(twIterator);


            Console.ReadKey();
        }
        //sample 1
        public static void PrintUsers(IIterator iterate)
        {
            while (!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
