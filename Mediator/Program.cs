using System;
using System.Threading.Tasks;
using Mediator.Sample1;

namespace Mediator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Sample 1
            IAirTrafficControl mehrabadAirTrafficControl = new MehrabadAirTrafficControl();

            AirplaneBase airbusAirplane = new AirbusAirplane(mehrabadAirTrafficControl);
            AirplaneBase boeingAirplane = new BoeingAirplane(mehrabadAirTrafficControl);
            AirplaneBase jetAirplane = new JetAirplane(mehrabadAirTrafficControl);

            mehrabadAirTrafficControl.AddAirplanes(airbusAirplane, boeingAirplane,jetAirplane);

            airbusAirplane.Send("Can we land right now ?");
            Console.WriteLine("----------");

            boeingAirplane.Send("No! We're landing, wait ...");
            Console.WriteLine("----------");

            jetAirplane.Send("I haven't reached yet ");
            Console.WriteLine("----------");

            // Demonstrate landing ...
            Console.WriteLine("Boeing is landing ...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("----------");

            boeingAirplane.Send("We landed.");
            Console.WriteLine("----------");

            airbusAirplane.Send("OK, We're going to land ...");
            Console.WriteLine("----------");

            boeingAirplane.Send("Good luck.");
        }
    }
}
