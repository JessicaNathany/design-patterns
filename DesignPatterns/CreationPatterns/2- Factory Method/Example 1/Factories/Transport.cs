using CreationPatterns._2__Factory_Method.Example_1.Interface;
namespace CreationPatterns._2__Factory_Method.Example_1.Factories
{
    abstract class Transport
    {
        public void StartTransport()
        {
            IVehicles vehicles = CreateTransport();
            vehicles.StartRoute();
        }

        protected abstract IVehicles CreateTransport();
    }
}
