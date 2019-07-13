using System;
using Decorator.Sample1;
using Decorator.Sample2;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            //sample 2
            //var price = new OilChange(new TireRotation(new BaseInception())).GetService();
            //Console.WriteLine(price);

            //sample 1
            Cake cake = new Cake();
            Console.WriteLine(cake.Bake() + " ," + cake.GetPrice());

            Creamy creamy = new Creamy(cake);
            Console.WriteLine(creamy.Bake() + " ," + creamy.GetPrice());

            SpecialBake specialBake = new SpecialBake(cake);
            Console.WriteLine(specialBake.Bake() + " ," + specialBake.GetPrice());

            Creamy csbLine = new Creamy(new SpecialBake(new Cake()));
            Console.WriteLine($"sp {csbLine.Bake() + " " + csbLine.GetPrice()}");

            Console.ReadKey();
        }
    }
}
