using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample3
{
    public class ICTMinisterFactory : MinisterFactory
    {
        protected override IGovernmentAuthority GovernmentAuthority()
        {
            return new TechAuthority();
        }
    }
    public class HealthMinisterFactory : MinisterFactory
    {
        protected override IGovernmentAuthority GovernmentAuthority()
        {
            return new HealthAuthority();
        }
    }
}
