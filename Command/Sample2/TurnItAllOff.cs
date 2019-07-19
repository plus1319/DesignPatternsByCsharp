using System;
using System.Collections;
using System.Collections.Generic;

namespace Command.Sample2
{
    public class TurnItAllOff : ICommand
    {
        private IList<IElectronicDevice> _electronicDevices;

        public TurnItAllOff(IList<IElectronicDevice> electronicDevices)
        {
            _electronicDevices = electronicDevices;
        }

        public void Execute()
        {
            foreach (var electronicDevice in _electronicDevices)
            {
                electronicDevice.Off();
            }
        }
        public void Undo()
        {
            foreach (var electronicDevice in _electronicDevices)
            {
                electronicDevice.On();
            }
        }
    }
}