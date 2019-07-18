namespace ChainOfResponsibility.Sample1
{
    public class MessageService
    {
        public void sendMessage(Message message)
        {
            MessageHandler nextHandler = null;
            foreach (var value in message.destination)
            {
                switch (value.Key)
                {
                    case Destination.FAX:
                        nextHandler = new FaxMessageHandler(nextHandler);
                        break;
                    case Destination.EMAIL:
                        nextHandler = new EmailMessageHandler(nextHandler);
                        break;
                    case Destination.SMS:
                        nextHandler = new SMSMessageHandler(nextHandler);
                        break;
                }
            }
            if(nextHandler != null )
                nextHandler.handle(message);

        }
    }
}