namespace AbstractFactory.Sample1
{
    public class Bmp2JpgConvertor : IConvertor
    {
        private readonly string _fileInput;

        public Bmp2JpgConvertor(string fileInput)
        {
            _fileInput = fileInput;
        }

        public string Convert()
        {
            return $"convert {_fileInput} 2 jpg";
        }
    }
    public class Bmp2PngConvertor : IConvertor
    {
        private readonly string _fileInput;

        public Bmp2PngConvertor(string fileInput)
        {
            _fileInput = fileInput;
        }

        public string Convert()
        {
            return $"convert {_fileInput} 2 png";
        }
    }
}