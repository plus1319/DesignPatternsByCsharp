using System.Collections.Generic;
using System.Text;

namespace Composite.Sample1
{
    public class Menu : MenuComposite
    {
        private List<MenuComposite> children = new List<MenuComposite>();
        public Menu(string name) : base(name)
        {
        }

        public override MenuComposite Add(MenuComposite menuComposite)
        {
           children.Add(menuComposite);
           return this;
        }

        public override MenuComposite Remove(MenuComposite menuComposite)
        {
            children.Remove(menuComposite);
            return this;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder("::menu::");
            stringBuilder.Append(Print());
            children.ForEach(leaf => stringBuilder.Append(leaf));
            return stringBuilder.ToString();
        }
    }
}