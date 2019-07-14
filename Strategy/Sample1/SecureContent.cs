namespace Strategy.Sample1
{
    public class SecureContent
    {
        private string raw;

        public SecureContent(string raw)
        {
            this.raw = raw;
        }

        public byte[] hashContent(IHashStrategy hashStrategy)
        {
           return hashStrategy.hash(raw);
        }
    }
}