using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample1
{
    interface IMemory
    {
        void GetData();

        void SetData();

        void Connect();
    }
}
