using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample1
{
    public class SDCardMemory
    {
        public void ReadData()
        {
            Console.WriteLine("getting data");
        }

        public void SendData()
        {
            Console.WriteLine("sending data");
        }

        public void ConnectToDevice()
        {
            Console.WriteLine("connected");

            SendData();
            ReadData();
        }
    }
}
