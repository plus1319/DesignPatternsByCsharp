using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample1
{
    public class ImageConvertorFactory
    {
        public string Png = "png";
        public string Bitmap = "bitmap";
        public string Jpg = "jpg";
        public IImageConvertor ConvertImage(string pic, string picConvert)
        {
            if (picConvert.Equals(Png))
                 return new PngConvert(pic);
            else if (picConvert.Equals(Bitmap))
                return new BitmapConvert(pic);
            else if (picConvert.Equals(Jpg))
                return new JpgConvert(pic);

            throw new Exception("bad request");
        }
    }
}
