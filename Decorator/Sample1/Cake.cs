namespace Decorator.Sample1
{
    public class Cake : IBakery
    {
        public string Bake() { return "Cake baked"; }
        public double GetPrice() { return 2000; }
    }
}