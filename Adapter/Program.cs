using System;
using Adapter.Sample1;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample 1
            IMemory cameraMemory = new CameraMemory();

            IMemory sdCardMemor = new SDCardMemoryAdapter();

            Console.WriteLine("The Camera Memory");
            Console.WriteLine("---------------------");
            cameraMemory.Connect();

            Console.WriteLine("\n");

            Console.WriteLine("The SDCard Memory");
            Console.WriteLine("---------------------");
            sdCardMemor.Connect();

            Console.ReadKey();
        }
    }
}
