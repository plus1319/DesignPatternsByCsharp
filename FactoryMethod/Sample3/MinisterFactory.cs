using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample3
{
    public abstract class MinisterFactory
    {
        //factory method
        abstract protected IGovernmentAuthority GovernmentAuthority();

        public void Manage()
        {
            var authorityGuy = this.GovernmentAuthority();
            authorityGuy.EnforceLaw();
        }
    }
}
