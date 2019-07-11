using System;
using AbstractFactory.Sample1;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample1
           IMediaFactory imageMedia = MediaFactory.CreateMediaFactory(MediaType.IMAGE);
           var bmpConvertor = imageMedia.CreateConvertor("Felani.bmp", CodecType.PNG);
           Console.WriteLine(bmpConvertor.Convert());

           IMediaFactory musicMedia = MediaFactory.CreateMediaFactory(MediaType.MUSIC);
           var mp3Convertor = musicMedia.CreateConvertor("Felani.mp3", CodecType.WAV);
           Console.WriteLine(mp3Convertor.Convert());

            Console.ReadKey();
        }
    }
}
