namespace Decorator.Sample1
{
    public class Creamy : Decorator
    {
        public Creamy(IBakery bakery) : base(bakery)
        {
            this.bake = "Creamy"; this.price = 500;
        }
    }
}