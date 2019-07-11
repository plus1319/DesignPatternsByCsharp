using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample2
{
    public class ZagrosAirline : IAirline
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Tehran-Mashhad",
                "Kish-Ahvaz"
            };
        }
    }
    public class MahaAirline : IAirline
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Rasht-Shiraz",
                "Tehran-Ahvaz"
            };
        }
    }
}
