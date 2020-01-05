using System;
using Template.Sample1;
using Template.Sample2;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 2
            DataExporter dataExporter = new ExcelExporter();
            dataExporter.GetReport();

            //==========================================================================

            //sample 1
            //BaseEngineering  baseEngineering = new SoftwareEngineering();
            //baseEngineering.Study();



            Console.ReadKey();
        }
    }
}
