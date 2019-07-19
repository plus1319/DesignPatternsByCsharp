namespace Command.Sample1
{
    public class ShutDownCommand : Command
    {
        public ShutDownCommand(IServerAgent serverAgent) : base(serverAgent)
        {
        }

        public override void Execute()
        {
            serverAgent.Connect();
            serverAgent.ShutDown();
            serverAgent.DisConnect();
        }
    }
    public class RebootCommand : Command
    {
        public RebootCommand(IServerAgent serverAgent) : base(serverAgent)
        {
        }

        public override void Execute()
        {
            serverAgent.Connect();
            serverAgent.Reboot();
            serverAgent.DisConnect();
        }
    }
}