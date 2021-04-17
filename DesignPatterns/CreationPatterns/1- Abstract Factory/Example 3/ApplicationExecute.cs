using CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts;
using CreationPatterns._1__Abstract_Factory.Example_3.Factories;
using CreationPatterns._1__Abstract_Factory.Example_3.Landvehicles;

namespace CreationPatterns._1__Abstract_Factory.Example_3
{
    public class ApplicationExecute
    {
        private IAircraft aircraft;
        private ILandvehicle vehicle;

        public ApplicationExecute(ITransporFactory factory)
        {
            factory.CreateTransportAirCraft();
            factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
