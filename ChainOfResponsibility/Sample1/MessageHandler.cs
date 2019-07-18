namespace ChainOfResponsibility.Sample1
{
    public abstract class MessageHandler
    {
        protected MessageHandler nextHandler;

        protected MessageHandler(MessageHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void handle(Message message);
    }
}