using System;
using System.Threading;

namespace State.Sample1
{
    //state
    public abstract class RemoteControl
    {
        public abstract void SwitchState(Tv tv);
    }
    //concrete state A
    public sealed class On : RemoteControl
    {
        //================================================================================
        //Singleton for this class because I don't want to make instance every request
        private On() { }
        private static Lazy<On> _instance =
            new Lazy<On>(CreateOnSingleton, LazyThreadSafetyMode.ExecutionAndPublication);

        public static On GetInstance = _instance.Value;

        private static On CreateOnSingleton()
        {
            return new On();
        }
        //================================================================================

        public override void SwitchState(Tv tv)
        {
            Console.WriteLine("Tv is now On");
            tv.setState(Off.GetInstance);
            Console.WriteLine("TV is powering off ...");
        }
    }
    //concrete state B
    public sealed class Off : RemoteControl
    {
        //================================================================================
        //Singleton for this class because I don't want to make instance every request
        private Off() { }
        private static Lazy<Off> _instance =
            new Lazy<Off>(CreateOffSingleton, LazyThreadSafetyMode.ExecutionAndPublication);

        public static Off GetInstance = _instance.Value;
        private static Off CreateOffSingleton()
        {
            return new Off();
        }
        //================================================================================
        public override void SwitchState(Tv tv)
        {
            Console.WriteLine("Tv is now Off");
            tv.setState(On.GetInstance);
            Console.WriteLine("TV is powering on ...");
        }
    }
    //public sealed class Ruined : RemoteControl
    //{
    //    //================================================================================
    //    //Singleton for this class because I don't want to make instance every request
    //    private Ruined() { }
    //    private static Lazy<Ruined> _instance =
    //        new Lazy<Ruined>(CreateOffSingleton, LazyThreadSafetyMode.ExecutionAndPublication);

    //    public static Ruined GetInstance = _instance.Value;
    //    private static Ruined CreateOffSingleton()
    //    {
    //        return new Ruined();
    //    }
    //    //================================================================================
    //    public override void SwitchState(Tv tv)
    //    {
    //        Console.WriteLine("Tv is now Ruined");
    //        tv.setState(Ruined.GetInstance);
    //        Console.WriteLine("TV is powering on ...");
    //    }
    //}
}