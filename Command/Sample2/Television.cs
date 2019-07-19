using System;

namespace Command.Sample2
{
    public class Television : IElectronicDevice
    {
        private int _volume = 0;
        public void On()
        {
            Console.WriteLine("TV is On");
        }

        public void Off()
        {
            Console.WriteLine("TV is Off");
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine($"TV volume is at {_volume}");
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine($"TV volume is at {_volume}");
        }
    }
    public class Radio : IElectronicDevice
    {
        private int _volume = 0;
        public void On()
        {
            Console.WriteLine("Radio is On");
        }

        public void Off()
        {
            Console.WriteLine("Radio is Off");
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine($"Radio volume is at {_volume}");
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine($"Radio volume is at {_volume}");
        }
    }
}