using System;
using FactoryMethod.Sample1;
using FactoryMethod.Sample2;
using FactoryMethod.Sample3;
using FactoryMethod.Sample4;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 4
            var point = Point.PointFactory.NewCartesianPoint(1.0, Math.PI / 2);
            Console.WriteLine(point.ToString());

            var defaultPoint = Point.Origin;
            Console.WriteLine(defaultPoint.ToString());


            //---------------------------------------------------------------------------------
            //sample 3
            //var azarJahromi = new ICTMinisterFactory();
            //azarJahromi.Manage();

            //var gazizadeh = new HealthMinisterFactory();
            //gazizadeh.Manage();

            //---------------------------------------------------------------------------------
            //sample 2
            //IAirlineFactory airlineFactory = new AirlineFactory();

            //var defaultAirline = airlineFactory.Create();
            //var mahanAirline = airlineFactory.Create(AirlineName.Mahan);

            //Console.WriteLine($"default flights:");
            //foreach (var flight in defaultAirline.GetFlights())
            //{
            //    Console.WriteLine(flight);
            //}

            //Console.WriteLine($"Mahan Air flights:");
            //foreach (var flight in mahanAirline.GetFlights())
            //{
            //    Console.WriteLine(flight);
            //}

            //---------------------------------------------------------------------------------
            //sample 1
            //string pic = "Football";

            //var imageConvertor = new ImageConvertorFactory();
            //IImageConvertor png = imageConvertor.ConvertImage(pic, imageConvertor.Png);
            //png.Convert();

            //IImageConvertor bitmap = imageConvertor.ConvertImage(pic, imageConvertor.Bitmap);
            //bitmap.Convert();

            //IImageConvertor jpg = imageConvertor.ConvertImage(pic, imageConvertor.Jpg);
            //jpg.Convert();

            Console.ReadKey();
        }
    }
}
