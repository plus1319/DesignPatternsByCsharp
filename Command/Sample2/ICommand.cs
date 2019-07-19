namespace Command.Sample2
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class TurnTVOn : ICommand
    {
        private IElectronicDevice theDevice;

        public TurnTVOn(IElectronicDevice theDevice)
        {
            this.theDevice = theDevice;
        }

        public void Execute()
        {
            theDevice.On();
        }

        public void Undo()
        {
            theDevice.Off();
        }
    }
    public class TurnTVOff : ICommand
    {
        private IElectronicDevice theDevice;

        public TurnTVOff(IElectronicDevice theDevice)
        {
            this.theDevice = theDevice;
        }

        public void Execute()
        {
            theDevice.Off();
        }
        public void Undo()
        {
            theDevice.Off();
        }
    }
    public class TurnTVUp : ICommand
    {
        private IElectronicDevice theDevice;

        public TurnTVUp(IElectronicDevice theDevice)
        {
            this.theDevice = theDevice;
        }

        public void Execute()
        {
            theDevice.VolumeUp();
        }
        public void Undo()
        {
            theDevice.Off();
        }
    }
    public class TurnTVDown : ICommand
    {
        private IElectronicDevice theDevice;

        public TurnTVDown(IElectronicDevice theDevice)
        {
            this.theDevice = theDevice;
        }

        public void Execute()
        {
            theDevice.VolumeDown();
        }
        public void Undo()
        {
            theDevice.Off();
        }
    }

}