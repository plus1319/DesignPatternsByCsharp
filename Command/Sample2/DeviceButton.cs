namespace Command.Sample2
{
    //invoker
    public class DeviceButton
    {
        private ICommand _command;

        public DeviceButton(ICommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }
        public void Undo()
        {
            _command.Undo();
        }
    }
}