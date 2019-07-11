using System;
using System.Linq;

namespace AbstractFactory.Sample1
{
    public class MusicConvertorFactory : IMediaFactory
    {
        public IConvertor CreateConvertor(string fileInput, CodecType codecType)
        {
            string fileName = fileInput.Split('.').Last();
            if (fileName.Equals("mp3"))
                switch (codecType)
                {
                    case CodecType.WAV:
                        return new Mp3ToWavConvertor(fileInput);

                    case CodecType.AAC:
                        return new Mp3ToAccConvertor(fileInput);
                }

            throw new NotSupportedException("the music doesn't support");
        }
    }
}