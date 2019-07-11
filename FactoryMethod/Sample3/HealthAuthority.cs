using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample3
{
    public class HealthAuthority : IGovernmentAuthority
    {
        public void EnforceLaw()
        {
            Console.WriteLine("Stay healthy");
        }
    }
    public class TechAuthority : IGovernmentAuthority
    {
        public void EnforceLaw()
        {
            Console.WriteLine("Filter every thing you know");
        }
    }
}
