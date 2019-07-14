using System;

namespace FlyWeight.Sample1
{
    public interface IAlphabet
    {
        void Render(string font);
    }

    public class A : IAlphabet
    {
        public void Render(string font)
        {
            Console.WriteLine(GetType().Name + " has font of type " + font);
        }
    }
    public class B : IAlphabet
    {
        public void Render(string font)
        {
            Console.WriteLine(GetType().Name + " has font of type " + font);
        }
    }
}