using System;
using System.Threading;

namespace NullObject.Sample1
{
    public interface ILog
    {
        void Info(string msg);
    }
    public class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            Console.WriteLine($"console log:{msg}");
        }
    }

    public class NullLog : ILog
    {
        private NullLog() { }
        private static Lazy<NullLog> _instance =
            new Lazy<NullLog>(CreateNullLogSingleton,
                LazyThreadSafetyMode.ExecutionAndPublication);
        private static NullLog CreateNullLogSingleton() =>
         new NullLog();

        public static NullLog GetInstance = _instance.Value;
        public void Info(string msg)
        {
            //return default(int);
            //return default(bool);
        }
    }
}