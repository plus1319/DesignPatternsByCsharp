using System;
using System.Net;

namespace FactoryMethod.Sample4
{
    public class Point
    {
        private double x, y;

        //we should keep private ctor
        private Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}:{x} , {nameof(y)}: {y}";
        }
        public static Point Origin = new Point(0,0); //better
        //public static Point Origin2 => new Point(0,0);

        public static class PointFactory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta),rho * Math.Sin(theta));
            }
        }
    }
}