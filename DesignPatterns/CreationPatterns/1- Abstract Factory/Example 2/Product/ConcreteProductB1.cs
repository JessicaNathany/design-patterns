using CreationPatterns._1__Abstract_Factory.Example_2.Interface;

namespace CreationPatterns._1__Abstract_Factory.Example_2.Product
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}
