using CreationPatterns._2__Factory_Method.Example_1.Interface;
namespace CreationPatterns._2__Factory_Method.Example_1.Factories
{
    class CarTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Car();
        }
    }
}
