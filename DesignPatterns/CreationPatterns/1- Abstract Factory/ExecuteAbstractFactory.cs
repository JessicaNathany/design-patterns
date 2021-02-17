using CreationPatterns._1__Abstract_Factory.Example_2.ConcreteFactory;
using CreationPatterns._1__Abstract_Factory.Example_2.Interface;
using System;

namespace DesignPatterns_1_Creational_1_Abstract_Factory
{
    public class ExecuteAbstractFactory
    {
        public void ExampleOne()
        {
            Console.WriteLine("..:: Choice an option ::.. ");
           
        }

        public void ExampleTwo()
        {
            // This an example two the RefactoringGuru for more information, visit the repository link bellow
            // https://github.com/RefactoringGuru/design-patterns-csharp

            // EN: The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ExampleTwoClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ExampleTwoClientMethod(new ConcreteFactory2());
        }

        public void ExampleThree()
        {
            Console.WriteLine("..:: Choice an option ::.. ");
        }



        // this is method reference example two Abstract Factory
        private void ExampleTwoClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
