namespace AbstractFactory.Sample1
{
    public class Mp3ToWavConvertor : IConvertor
    {
        private readonly string _fileInput;

        public Mp3ToWavConvertor(string fileInput)
        {
            _fileInput = fileInput;
        }

        public string Convert()
        {
            return $"convert {_fileInput} 2 wav";
        }
    }
    public class Mp3ToAccConvertor : IConvertor
    {
        private readonly string _fileInput;

        public Mp3ToAccConvertor(string fileInput)
        {
            _fileInput = fileInput;
        }

        public string Convert()
        {
            return $"convert {_fileInput} 2 acc";
        }
    }
}