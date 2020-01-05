using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Sample2
{
    public abstract class DataExporter
    {
        public void ReadData()
        {
            Console.WriteLine("Data is reading from SQL Server Database");
        }

        public void ProcessData()
        {
            Console.WriteLine("Data is processing...!");
        }

        public abstract void PrintData();

        public void GetReport()
        {
            ReadData();
            ProcessData();
            PrintData();
        }
    }
}
