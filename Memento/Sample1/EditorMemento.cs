using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Sample1
{
    public class EditorMemento
    {
        private string _content;
        public EditorMemento(string content)
        {
            _content = content;
        }

        public string Content
        {
            get { return _content; }
        }
    }
}
