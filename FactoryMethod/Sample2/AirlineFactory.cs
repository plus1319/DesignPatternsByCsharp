using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FactoryMethod.Sample2
{
    public enum AirlineName
    {
        Zagros,
        Mahan,
    }
    public class AirlineFactory : IAirlineFactory
    {
        public IAirline Create()
        {
            return new ZagrosAirline();
        }

        public IAirline Create(Enum airLine)
        {
            IAirline airlineNew;
            switch (airLine)
            {
                case AirlineName.Zagros: airlineNew = new ZagrosAirline(); break;
                case AirlineName.Mahan: airlineNew = new MahaAirline(); break;
                default: throw new NotSupportedException("the airLine doesn't support");
            }
            return airlineNew;
        }
    }
}
