using System;
using Multiton.Sample1;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            var camera1 = Camera.GetCamera(1);
            var camera2 = Camera.GetCamera(2);
            Console.WriteLine($"{(camera1 == camera2).ToString()}");//false

            var camera3 = Camera.GetCamera(3);
            var anotherCamera3 = Camera.GetCamera(3);
            Console.WriteLine($"{(camera3 == anotherCamera3).ToString()}");//true

            Console.ReadKey();
        }
    }
}
