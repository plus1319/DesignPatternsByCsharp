using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;

namespace Singleton.Sample1
{
    //sealed:means can not inheritance in this class
    public sealed class MathSingleton
    {
        private static MathSingleton _instance;
        // Lock synchronization object
        private static object _syncLock = new object();

        public MathSingleton() { }
        //************************************************************************
        //lazy
        public static MathSingleton GetInstance1 => _instance ?? (_instance = new MathSingleton());
        //************************************************************************
        public static MathSingleton GetInstance2()
        {
            //lazy loading
            if (_instance == null)
                //thread-safe
                lock (_syncLock)
                    //double check for thread-safe
                    if (_instance == null)
                        return _instance = new MathSingleton();

            return _instance;
        }
        //************************************************************************
        //lazy
        private static Lazy<MathSingleton> _instance1 = new Lazy<MathSingleton>
            (()=> new MathSingleton());
        public static MathSingleton GetInstance3 => _instance1.Value;
        //************************************************************************
        //lazy and thread-safe
        private static Lazy<MathSingleton> _instance2 = new Lazy<MathSingleton>
            (createMathSingleton, LazyThreadSafetyMode.ExecutionAndPublication);
        public static MathSingleton GetInstance4 => _instance2.Value;
        private static MathSingleton createMathSingleton()
        {
            return  new MathSingleton();
        }
        //************************************************************************
        public void Sum()
        {
            Console.WriteLine("Sum");
        }

        public void Pow()
        {
            Console.WriteLine("Power");
        }
    }
}
