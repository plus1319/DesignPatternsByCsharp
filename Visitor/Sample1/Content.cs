using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Visitor.Sample1;

namespace Visitor.Sample1
{
    //element
    public class Content
    {
        public int Data { get; set; }
       
        public Content(int data)
        {
            Data = data;
        }

        public void accept(ContentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
