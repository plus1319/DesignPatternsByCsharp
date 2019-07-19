using System;

namespace Command.Sample1
{
    public interface IServerAgent
    {
        void Connect();
        void DisConnect();
        void ShutDown();
        void Reboot();
    }
}