using System;

namespace AbstractFactory.Sample1
{
    public enum MediaType
    {
        IMAGE, MUSIC
    }
    public class MediaFactory
    {
        public static IMediaFactory CreateMediaFactory(MediaType mediaType)
        {
            switch (mediaType)
            {
                case MediaType.IMAGE: return new ImageConvertorFactory();
                case MediaType.MUSIC: return new MusicConvertorFactory();
            }

            throw new NotSupportedException("the image doesn't support");
        }
    }
}