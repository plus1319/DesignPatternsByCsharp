using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Sample1
{
    //mediator
    public interface IAirTrafficControl
    {
        void AddAirplanes(params AirplaneBase[] airplanes);

        void SendMessage(string message, AirplaneBase messageProducerAirplane);
    }
    // Concrete Class for mediator
    public class MehrabadAirTrafficControl : IAirTrafficControl
    {
        readonly List<AirplaneBase> _airplanes = new List<AirplaneBase>();

        public void AddAirplanes(params AirplaneBase[] airplanes)
        {
            _airplanes.AddRange(airplanes);
        }

        public void SendMessage(string message, AirplaneBase messageProducerAirplane)
        {
            List<AirplaneBase> otherAirplanes = _airplanes
                .Where(airplane => airplane != messageProducerAirplane)
                .ToList();

            foreach (var airplane in otherAirplanes)
                airplane.Notify(message);
        }
    }
    //Colleague
    public abstract class AirplaneBase
    {
        public abstract void Send(string message);

        public abstract void Notify(string message);
    }
    // Concrete Class Colleague
    public class AirbusAirplane : AirplaneBase
    {
        protected readonly IAirTrafficControl AirTrafficControl;

        public AirbusAirplane(IAirTrafficControl airTrafficControl)
        {
            AirTrafficControl = airTrafficControl;
        }

        public override void Send(string message)
        {
            Console.WriteLine("Airbus airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Airbus airplane gets message: " + message);
        }
    }
    // Concrete Class Colleague
    public class BoeingAirplane : AirplaneBase
    {
        protected readonly IAirTrafficControl AirTrafficControl;

        public BoeingAirplane(IAirTrafficControl airTrafficControl)
        {
            AirTrafficControl = airTrafficControl;
        }

        public override void Send(string message)
        {
            Console.WriteLine("Boeing airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Boeing airplane gets message: " + message);
        }
    }
    // Concrete Class Colleague
    public class JetAirplane : AirplaneBase
    {
        protected readonly IAirTrafficControl AirTrafficControl;

        public JetAirplane(IAirTrafficControl airTrafficControl)
        {
            AirTrafficControl = airTrafficControl;
        }

        public override void Send(string message)
        {
            Console.WriteLine("Jet airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Jet airplane gets message: " + message);
        }
    }

}
