using CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts;
using CreationPatterns._1__Abstract_Factory.Example_3.Landvehicles;

namespace CreationPatterns._1__Abstract_Factory.Example_3.Factories
{
    class UberTransport : ITransporFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Airplane();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
