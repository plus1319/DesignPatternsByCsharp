using System.Collections.Generic;

namespace ChainOfResponsibility.Sample1
{
    public enum Destination
    {
        SMS, FAX, EMAIL
    }
    public class Message
    {
        private string _value;
        public Dictionary<Destination, string> destination;

        public Message(string value,Dictionary<Destination, string> destination)
        {
            this.destination = destination;
            this._value = value;
        }

        public static MessageBuilder getBuilder()
        {
            return new MessageBuilder();
        }
    }
    public class MessageBuilder
    {
        private string _value;
        private Dictionary<Destination, string> _destination = new Dictionary<Destination, string>();

        public MessageBuilder AddDestination(Destination destination, string number)
        {
            _destination.Add(destination,number);
            return this;
        }
        public MessageBuilder setValue(string value)
        {
            _value = value;
            return this;
        }

        public Message Build()
        {
            return new Message(_value, _destination);
        }


    }
}