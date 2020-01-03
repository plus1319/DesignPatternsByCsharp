using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Sample1
{
    public class FallsIllEventArgs
    {
        public string Address;
    }
    //Observable or subject or publisher
    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this,new FallsIllEventArgs{Address = "123 London Street"});
        }
        public event EventHandler<FallsIllEventArgs> FallsIll;
    }
}
