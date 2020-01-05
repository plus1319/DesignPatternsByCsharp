using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Sample1
{
    public class SoftwareEngineering : BaseEngineering
    {
        public override void AdditionalStudy()
        {
            Console.WriteLine("database");
            Console.WriteLine("c++");
        }
    }
    public class ElectricalEngineering : BaseEngineering
    {
        public override void AdditionalStudy()
        {
            Console.WriteLine("micro take");
        }
    }
}
