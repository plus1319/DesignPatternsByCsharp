using System;
using System.Linq;

namespace ChainOfResponsibility.Sample1
{
    public class FaxMessageHandler : MessageHandler
    {
        public FaxMessageHandler(MessageHandler nextHandler) : base(nextHandler)
        {
        }

        public override void handle(Message message)
        {
            if (message.destination.ContainsKey(Destination.FAX))
            {
                Console.WriteLine($"message sent to {message.destination[Destination.FAX]} via Fax");
            }
            if (nextHandler != null)
            {
                nextHandler.handle(message);
            }
        }
    }
    public class EmailMessageHandler : MessageHandler
    {
        public EmailMessageHandler(MessageHandler nextHandler) : base(nextHandler)
        {
        }

        public override void handle(Message message)
        {
            if (message.destination.ContainsKey(Destination.EMAIL))
            {
                Console.WriteLine($"message sent to {message.destination[Destination.EMAIL]} via Email");
            }
            if (nextHandler != null)
            {
                nextHandler.handle(message);
            }
        }
    }
    public class SMSMessageHandler : MessageHandler
    {
        public SMSMessageHandler(MessageHandler nextHandler) : base(nextHandler)
        {
        }

        public override void handle(Message message)
        {
            if (message.destination.ContainsKey(Destination.SMS))
            {
                Console.WriteLine($"message sent to {message.destination[Destination.SMS]} via SMS");
            }
            if (nextHandler != null)
            {
                nextHandler.handle(message);
            }
        }
    }
}