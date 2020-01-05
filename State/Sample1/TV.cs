using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample1
{
    //context
    public class Tv
    {
        private RemoteControl _state;

        public Tv(RemoteControl remoteControl)
        {
            _state = remoteControl;
        }

        public void setState(RemoteControl remoteControl)
        {
            _state = remoteControl;
        }

        public void toggleSwitch()
        {
            _state.SwitchState(this);
        }
    }
}
