using System;
using System.Collections.Generic;
using ChainOfResponsibility.Sample1;
using ChainOfResponsibility.Sample2;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            //sample 2
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            sam.ProcessRequest(p);


            //sample 1
            //var message = new MessageBuilder()
            //    .setValue("hi there is a message ")
            //    .AddDestination(Destination.FAX, "9343434343")
            //    //.AddDestination(Destination.SMS, "9934834343")
            //    .AddDestination(Destination.EMAIL,"sdsd@sds.com")
            //    .Build();

            //var messageService = new MessageService();
            //messageService.sendMessage(message);

            Console.ReadKey();

        }
    }
}
