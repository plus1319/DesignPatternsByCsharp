namespace Strategy.Sample1
{
    public interface IHashStrategy
    {
        byte[] hash(string raw);
    }
}