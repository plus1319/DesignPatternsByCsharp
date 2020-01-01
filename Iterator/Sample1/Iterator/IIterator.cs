using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Sample1.Iterator
{
    public interface IIterator
    {
        void First(); //reset back to first
        string Next(); //get next
        bool IsDone(); //end of collection check
        string CurrentItem(); //get current item
    }
}
