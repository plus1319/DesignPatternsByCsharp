using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample1
{
    public class MailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email ... : {message}");
        }
    }
    public class TelegramSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending message with Telegram API ... : {message}");
        }
    }
    public class SkypeSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending message with Skype API ... : {message}");
        }
    }
}
