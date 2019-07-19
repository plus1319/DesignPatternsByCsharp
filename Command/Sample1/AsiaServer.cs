using System;

namespace Command.Sample1
{
    public class AsiaServer : IServerAgent
    {
        public void Connect()
        {
            Console.WriteLine("Asia Server Connect");
        }

        public void DisConnect()
        {
            Console.WriteLine("Asia Server DisConnect");
        }

        public void ShutDown()
        {
            Console.WriteLine("Asia Server ShutDown");
        }

        public void Reboot()
        {
            Console.WriteLine("Asia Server Reboot");
        }
    }
    public class EuropeServer : IServerAgent
    {
        public void Connect()
        {
            Console.WriteLine("Europe Server Connect");
        }

        public void DisConnect()
        {
            Console.WriteLine("Europe Server DisConnect");
        }

        public void ShutDown()
        {
            Console.WriteLine("Europe Server ShutDown");
        }

        public void Reboot()
        {
            Console.WriteLine("Europe Server Reboot");
        }
    }
}