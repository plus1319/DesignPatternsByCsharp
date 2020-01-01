using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample1
{
    public class Context
    {
        public string Source { get; set; }
        public char Vocabulary { get; set; }
        public bool Result { get; internal set; }
        public int Position { get; set; }
    }
}
