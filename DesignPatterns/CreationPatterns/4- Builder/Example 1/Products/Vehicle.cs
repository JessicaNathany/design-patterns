using CreationPatterns._4__Builder.Example_1.Components;

namespace CreationPatterns._4__Builder.Example_1.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private AirBag airBag;

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Transmission Transmission
        {
            get => transmission;
            set => transmission = value;
        }

        public AirBag AirBag
        {
            get => airBag;
            set => airBag = value;
        }
    }
}
