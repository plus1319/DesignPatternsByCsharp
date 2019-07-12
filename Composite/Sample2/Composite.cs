using System;
using System.Collections.Generic;

namespace Composite.Sample2
{
    public class Composite : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();
        private string _name;

        public Composite(string name)
        {
            _name = name;
        }

        public Composite Add(IComponent component)
        {
            _children.Add(component);
            return this;
        }
        public Composite Remove(IComponent component)
        {
            _children.Remove(component);
            return this;
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + ' ' + _name);
            //_children.ForEach(leaf => leaf.Display(depth + 2));
            // Recursively display child nodes
            foreach (IComponent component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}