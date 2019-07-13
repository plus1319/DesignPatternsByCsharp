namespace Decorator.Sample1
{
    public class SpecialBake : Decorator
    {
        public SpecialBake(IBakery bakery) : base(bakery)
        {
            this.bake = "Special Bake";
            this.price = 50;
        }
    }
}