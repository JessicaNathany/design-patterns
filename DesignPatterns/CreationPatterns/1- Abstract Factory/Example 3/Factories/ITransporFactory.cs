using CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts;
using CreationPatterns._1__Abstract_Factory.Example_3.Landvehicles;

namespace CreationPatterns._1__Abstract_Factory.Example_3.Factories
{
    public interface ITransporFactory
    {
        IAircraft CreateTransportAirCraft();
        ILandvehicle CreateTransportVehicle(); 
    }
}
