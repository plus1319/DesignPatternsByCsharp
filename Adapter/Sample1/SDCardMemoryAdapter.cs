using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample1
{
    public class SDCardMemoryAdapter : IMemory
    {
        private SDCardMemory _memory;

        public SDCardMemoryAdapter()
        {
            _memory = new SDCardMemory();
        }

        public void Connect()
        {
            _memory.ConnectToDevice();
        }

        public void GetData()
        {
            _memory.ReadData();
        }

        public void SetData()
        {
            _memory.SendData();
        }
    }
}
