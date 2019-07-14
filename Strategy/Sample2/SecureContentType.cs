namespace Strategy.Sample2
{
    public class SecureContentType<T> where T : IHashStrategyType ,new()
    {
        private string raw;
        private IHashStrategyType _hashStrategy = new T();
        public SecureContentType(string raw)
        {
            this.raw = raw;
        }
        public byte[] hashContent()
        {
            return _hashStrategy.hash(raw);
        }
    }
}