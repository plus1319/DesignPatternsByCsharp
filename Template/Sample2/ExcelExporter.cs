using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Sample2
{
    public class ExcelExporter : DataExporter
    {
        public override void PrintData()
        {
            Console.WriteLine("Data exported to Microsoft Excel!");
        }
    }

    public class PDFExporter : DataExporter
    {
        public override void PrintData()
        {
            Console.WriteLine("Data exported to PDF!");
        }
    }
}
