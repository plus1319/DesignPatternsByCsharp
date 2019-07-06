using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample1
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
