using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample2
{
    public interface IAirlineFactory
    {
        IAirline Create();

        IAirline Create(Enum airLine);
    }
}
