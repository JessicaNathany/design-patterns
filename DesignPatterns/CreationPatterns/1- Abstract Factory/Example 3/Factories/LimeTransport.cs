using CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts;
using CreationPatterns._1__Abstract_Factory.Example_3.Landvehicles;

namespace CreationPatterns._1__Abstract_Factory.Example_3.Factories
{
    public class LimeTransport : ITransporFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Drone();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Scotter();
        }
    }
}
