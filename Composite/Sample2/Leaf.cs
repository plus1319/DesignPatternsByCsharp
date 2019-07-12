using System;

namespace Composite.Sample2
{
    public class Leaf : IComponent
    {
        private String name = string.Empty;
        public Leaf(string name)
        {
            this.name = name;
        }

        public void Display(int depth)
        {

            Console.WriteLine(new String('-', depth) + ' ' + name);

        }
    }
}