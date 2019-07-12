using System.Runtime.InteropServices.ComTypes;

namespace Composite.Sample1
{
    public class MenuItem : MenuComposite
    {
        public MenuItem(string name) : base(name)
        {
        }

        public override MenuComposite Add(MenuComposite menuComposite)
        {
            throw new System.NotImplementedException();
        }

        public override MenuComposite Remove(MenuComposite menuComposite)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "\t:item:" + Print();
        }
    }
}