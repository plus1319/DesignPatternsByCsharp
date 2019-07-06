using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample1
{
    public class CameraMemory : IMemory
    {
        public void GetData()
        {
            Console.WriteLine("getting data");

        }

        public void SetData()
        {
            Console.WriteLine("sending data");
        }

        public void Connect()
        {
            Console.WriteLine("connected");

            GetData();
            SetData();
        }
    }
}
