using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Sample1
{
   public class Editor
   {
       private string _content;
       private EditorMemento _memento;
        public Editor()
        {
            _memento = new EditorMemento(string.Empty);
        }

        public void Type(string words)
        {
            _content = string.Concat(_content, " ", words);
        }

        public string Content
        {
            get { return _content; }
        }

        public void Save()
        {
            _memento = new EditorMemento(_content);
        }

        public void Restore()
        {
            _content = _memento.Content;
        }
    }
}
