using System;
using Builder.Sample1;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            //sample 1
            Console.WriteLine("---------- Builder example");
            var myWebSite = new WebSiteBuilder("My Site")
                .AddBlogModule()
                .AddImageGalleryModule()
                .Build();
            Console.WriteLine(myWebSite.GetSiteDescription());



            Console.ReadKey();
        }
    }
  
}
