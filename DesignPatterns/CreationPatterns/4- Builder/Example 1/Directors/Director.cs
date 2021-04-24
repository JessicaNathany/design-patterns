using CreationPatterns._4__Builder.Example_1.Builders;
using CreationPatterns._4__Builder.Example_1.Components;

namespace CreationPatterns._4__Builder.Example_1.Directors
{
    class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }
        public void ConstructSUV()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(6);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            builder.SetAirBagType(AirBag.AIRBAGS_FRONT);
        }
    }
}
