using DesignPatterns._1__Creational._1._2_Factory_Method;
using DesignPatterns_1_Creational_1_Abstract_Factory;
using System;

namespace CreationPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Creational Patterns select an option ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Abstract Factory - Example One");
            Console.WriteLine("2 - Abstract Factory - Example Products");
            Console.WriteLine("3 - Abstract Factory - Example Transport");
            Console.WriteLine("4 - Factory Method   - Example Transport");
            Console.WriteLine("5 - Factory Method   - Example Banks");
            Console.WriteLine("------------------------");
    
            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    new ExecuteAbstractFactory().ExampleOne();
                    break;

                case '2':
                    new ExecuteAbstractFactory().Products();
                    break;

                case '3':
                    new ExecuteAbstractFactory().Transport();
                    break;

                case '4':
                    new ExecuteFactoryMethod().Transport();
                    break;

                case '5':
                    new ExecuteFactoryMethod().Banks();
                    break;
            }
        }
    }
}
