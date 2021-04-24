using CreationPatterns._4__Builder.Example_1.Components;
using CreationPatterns._4__Builder.Example_1.Products;

namespace CreationPatterns._4__Builder.Example_1.Builders
{
    interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirBagType(AirBag airBag);
    }
}
