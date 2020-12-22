using System;
using ExecucaoAbstractFactory = DesignPatterns_1_Creational_1_Abstract_Factory.ExecucaoAbstractFactory;
using FactoryMethod = DesignPatterns._1__Creational._1._2_Factory_Method.FactoryMethod;
using Singleton = DesignPatterns._1__Creational._1._3_Singleton.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(" ..:: Choose an Patterns option ::..");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.WriteLine("Creational Patterns");
            Console.WriteLine();
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.WriteLine("Structural Patterns");
            Console.WriteLine();
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine();
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Execute();
                    break;

                case '2':
                    FactoryMethod.Execute();
                    break;

                case '3':
                    Singleton.Execute();
                    break;
            }
        }
    }
}
