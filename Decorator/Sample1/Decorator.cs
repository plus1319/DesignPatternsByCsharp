using System.IO;

namespace Decorator.Sample1
{
    public abstract class Decorator : IBakery
    {
        private readonly IBakery _bakery;
        protected string bake;
        protected double price;

        protected Decorator(IBakery bakery)
        {
            _bakery = bakery;
        }

        public string Bake()
        {
            return _bakery.Bake() + "/" + bake;
        }

        public double GetPrice()
        {
            return _bakery.GetPrice() + price;
        }
    }
}