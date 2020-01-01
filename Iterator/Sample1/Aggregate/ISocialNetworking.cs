using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Sample1.Iterator;

namespace Iterator.Sample1.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}
