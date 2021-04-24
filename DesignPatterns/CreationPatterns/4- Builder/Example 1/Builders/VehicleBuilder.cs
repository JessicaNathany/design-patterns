using CreationPatterns._4__Builder.Example_1.Components;
using CreationPatterns._4__Builder.Example_1.Products;

namespace CreationPatterns._4__Builder.Example_1.Builders
{
    class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetAirBagType(AirBag airBag)
        {
            vehicle.AirBag = airBag;
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }
    }
}
