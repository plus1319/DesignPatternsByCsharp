using System;
using System.Linq;

namespace AbstractFactory.Sample1
{
    public class ImageConvertorFactory : IMediaFactory
    {
        public IConvertor CreateConvertor(string fileInput, CodecType codecType)
        {
            string fileName = fileInput.Split('.').Last();
            if (fileName.Equals("bmp"))
                switch (codecType)
                {
                    case CodecType.JPG:
                        return new Bmp2JpgConvertor(fileInput);

                    case CodecType.PNG:
                        return new Bmp2PngConvertor(fileInput);
                }

            throw new NotSupportedException("the image doesn't support");
        }
    }
}