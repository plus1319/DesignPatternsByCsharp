using System;
using Observer;
using Observer.Sample1;
using Observer.Sample2;

namespace Observer
{

    class Program
    {
        static void Main(string[] args)
        {
            //sample 2
            var messagePublisher = new MessageSubject();
            var postTitle = new Post() {Message = "this is new post"};

            var emailObserver = new EmailObserver();
            var telegramObserver = new TelegramObserver();
            var smsObserver = new SMSObserver();

            messagePublisher.MessagePublisher += emailObserver.onEmailObserver;
            messagePublisher.MessagePublisher += telegramObserver.onTelegramObsever;
            messagePublisher.MessagePublisher += smsObserver.onSMSObsever;
            messagePublisher.onPublisher(postTitle);
            //===================================================================

            //sample 1
            //var person = new Person();
            //person.FallsIll += CallDoctor;
            //person.CatchACold();


            Console.ReadKey();
        }


        ////Observer or subscriber
        //private static void CallDoctor(object sender, FallsIllEventArgs e)
        //{
        //    Console.WriteLine($"A doctor has been called to {e.Address}");
        //}
    }
}
