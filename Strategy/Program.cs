using System;
using Strategy.Sample1;
using Strategy.Sample2;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 2
            var secureType = new SecureContentType<MD5HashType>("password");
            var hashCodeType = secureType.hashContent();

            //sample 1
            var secure = new SecureContent("password");
            var hashCode = secure.hashContent(new MD5Hash());

            
            Console.ReadKey();
        }
    }
}
