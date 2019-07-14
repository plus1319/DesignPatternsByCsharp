using System.Security.Cryptography;
using System.Text;

namespace Strategy.Sample2
{
    public class MD5HashType : IHashStrategyType
    {
        public byte[] hash(string raw)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var hashData = md5.ComputeHash(new UTF8Encoding().GetBytes(raw));
                return hashData;
            }
        }
    }

    public class SHA256HashType : IHashStrategyType
    {
        public byte[] hash(string raw)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                var hashData = sha256.ComputeHash(new UTF8Encoding().GetBytes(raw));
                return hashData;
            }
        }
    }
}