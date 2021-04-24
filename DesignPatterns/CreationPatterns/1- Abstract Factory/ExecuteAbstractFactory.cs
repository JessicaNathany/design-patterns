using CreationPatterns._1__Abstract_Factory.Example_2.ConcreteFactory;
using CreationPatterns._1__Abstract_Factory.Example_2.Interface;
using CreationPatterns._1__Abstract_Factory.Example_3;
using CreationPatterns._1__Abstract_Factory.Example_3.Factories;
using System;

namespace DesignPatterns_1_Creational_1_Abstract_Factory
{
    /// <summary>
    /// Here we can call kinde examples the Abstract Factory
    /// </summary>
    public class ExecuteAbstractFactory
    {
        ITransporFactory factory;
        public void ExampleOne()
        {
            throw new NotImplementedException();
        }

        public void Products()
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

        public void Transport()
        {
            ApplicationExecute application = ConfigureApplication();

            application.StartRoute();
            Console.ReadLine();
        }

        private ApplicationExecute ConfigureApplication()
        {
            ApplicationExecute app;
            
            Console.WriteLine("Select a service the type of service");
            Console.WriteLine();
            Console.WriteLine("1- Uber");
            Console.WriteLine("2- 99");

            var company = Console.ReadKey();

            switch (company.KeyChar)
            {
                case '1':
                    factory = new UberTransport();
                    break;

                case '2':
                    factory = new NineNineTransport();
                    break;
            }

            app = new ApplicationExecute(factory);

            return app;
        }

        private void ExampleTwoClientMethod(IAbstractFactory factory)
        {
            // this is method reference example two Abstract Factory

            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
