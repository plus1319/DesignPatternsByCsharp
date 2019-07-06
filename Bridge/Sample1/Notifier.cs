using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample1
{
    public class Notifier
    {
        private IMessageSender _messageSender;

        public Notifier(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        //change type of sender
        public void ChangeMessageSender(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Notify(string message)
        {
            // Do other stuff here ...
            _messageSender.Send(message);
        }
    }
}
