using System;
using System.Collections.Generic;

namespace FlyWeight.Sample1
{
    public class FlyWeightFactory
    {
        private readonly Dictionary<string, IAlphabet> _dictionary = new Dictionary<string, IAlphabet>();
        public int Count { get { return _dictionary.Count; } }
        public IAlphabet GetObject(string key)
        {
            if (!_dictionary.ContainsKey(key))
                switch (key)
                {
                    case "A":
                        _dictionary.Add(key, new A());
                        Console.WriteLine("New object created");
                        break;
                    case "B":
                        _dictionary.Add(key, new B());
                        Console.WriteLine("New object created");
                        break;
                    default:
                        throw new Exception("Factory can not create given object");
                }
            else
                Console.WriteLine("Object reused");
            return _dictionary[key];
        }
    }
}