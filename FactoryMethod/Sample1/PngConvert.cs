using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample1
{
   public class PngConvert: IImageConvertor
   {
        private string _pic;
        public PngConvert(string pic)
        {
            _pic = pic;
        }
        public void Convert()
        {
            Console.WriteLine($"your {_pic} picture has converted to png");
        }
    }
   public class BitmapConvert : IImageConvertor
   {
       private string _pic;
       public BitmapConvert(string pic)
       {
           _pic = pic;
       }
       public void Convert()
       {
           Console.WriteLine($"your {_pic} picture has converted to bitmap");
       }
    }
   public class JpgConvert : IImageConvertor
   {
       private string _pic;
       public JpgConvert(string pic)
       {
           _pic = pic;
       }
       public void Convert()
       {
           Console.WriteLine($"your {_pic} picture has converted to jpg");
       }
    }
}
