namespace Command.Sample1
{
    public class ServerCommandInvoker
    {
        private Command command;

        public ServerCommandInvoker(Command command)
        {
            this.command = command;
        }

        public void run()
        {
            command.Execute();
        }
    }
}