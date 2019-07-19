namespace Command.Sample1
{
    public abstract class Command
    {
        protected IServerAgent serverAgent;

        protected Command(IServerAgent serverAgent)
        {
            this.serverAgent = serverAgent;
        }

        public abstract void Execute();
    }
}