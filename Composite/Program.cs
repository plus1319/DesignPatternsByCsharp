using System;
using Composite.Sample1;
using Composite.Sample2;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample2
            Sample2.Composite root1 = new Sample2.Composite("root");
            root1.Add(new Leaf("Leaf A"))
                 .Add(new Leaf("Leaf B"));

            Sample2.Composite comp1 = new Sample2.Composite("Developer");
            comp1.Add(new Leaf("Leaf DA"))
                 .Add(new Leaf("Leaf DB"));
            root1.Add(comp1);

            Sample2.Composite comp2 = new Sample2.Composite("SisAdmin");
            comp2.Add(new Leaf("Leaf SA"))
                 .Add(new Leaf("Leaf SB"));
            comp1.Add(comp2);

            Sample2.Composite comp3 = new Sample2.Composite("Analyzer");
            comp3.Add(new Leaf("Leaf aA"))
                 .Add(new Leaf("Leaf aB"));
            comp2.Add(comp3);

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf DD");
            comp1.Add(leaf)
                 .Remove(leaf);
            root1.Display(1);

            //sample1
            //Menu root1 = new Menu("root");
            //root1.Add(new MenuItem("Leaf A"))
            //     .Add(new MenuItem("Leaf B"));

            //Menu comp1 = new Menu("Developer");
            //comp1.Add(new MenuItem("Leaf DA"))
            //     .Add(new MenuItem("Leaf DB"));
            //root1.Add(comp1);

            //Menu comp2 = new Menu("SisAdmin");
            //comp2.Add(new MenuItem("Leaf SA"))
            //     .Add(new MenuItem("Leaf SB"));
            //comp1.Add(comp2);

            //Menu comp3 = new Menu("Analyzer");
            //comp3.Add(new MenuItem("Leaf aA"))
            //     .Add(new MenuItem("Leaf aB"));
            //comp2.Add(comp3);

            //Console.WriteLine(root1.ToString());

            Console.ReadKey();
        }
    }
}
