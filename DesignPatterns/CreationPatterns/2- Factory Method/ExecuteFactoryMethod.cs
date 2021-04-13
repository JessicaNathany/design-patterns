using CreationPatterns._2__Factory_Method.Example_1.Factories;
using System;

namespace DesignPatterns._1__Creational._1._2_Factory_Method
{
    public class ExecuteFactoryMethod
    {
        public void ExampleOne()
        {
            Console.WriteLine("Select a service the type of service");
            Console.WriteLine();
            Console.WriteLine("1- Uber");
            Console.WriteLine("2- Loggi");
            Console.WriteLine("3- Bike");

            var option = Console.ReadKey();
            Transport transport = null;

            switch (option.KeyChar)
            {
                case '1':
                    transport = new CarTransport();
                    break;

                case '2':
                    transport = new MotorcycleTransport();
                    break;

                case '3':
                    transport = new BikeTransport();
                    break;
            }

            if (transport != null) { transport.StartTransport(); }

            Console.ReadLine();
        }
    }
}
