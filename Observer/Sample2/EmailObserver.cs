using System;

namespace Observer.Sample2
{
    //Observer or subscriber
    public class EmailObserver
    {
        public void onEmailObserver(object sender, PostMessageEventArgs e)
        {
            Console.WriteLine($"we send email {e.Post.Message} to our client");

        }
    }
    //Observer or subscriber
    public class SMSObserver
    {
        public void onSMSObsever(object sender, PostMessageEventArgs e)
        {
            Console.WriteLine($"we send sms {e.Post.Message} to our client");
        }
    }
    //Observer or subscriber
    public class TelegramObserver
    {
        public void onTelegramObsever(object sender, PostMessageEventArgs e)
        {
            Console.WriteLine($"we send telegram message {e.Post.Message} to our phone number client");
        }
    }
}