using System;
using ExecucaoAbstractFactoryExample1 = DesignPatterns_1_Creational_1_Abstract_Factory.Exemplo_1.ExecucaoAbstractFactoryExample1;
using ExecucaoAbstractFactoryExample3 = DesignPatterns._1__Creational._1__Abstract_Factory.Example_3.ExecucaoAbstractFactoryExample3;

namespace DesignPatterns_1_Creational_1_Abstract_Factory
{
    public class ExecucaoAbstractFactory
    {
        public static void Execute()
        {
            Console.WriteLine("..:: Choose an example ::.. ");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1- Abstract Factory Example One");
            Console.WriteLine("2- Abstract Factory Example Two");
            Console.WriteLine("3- Abstract Factory Example Three");
            Console.WriteLine();

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactoryExample1.Execute();
                    break;

                //case '2':
                //    ExecucaoAbstractFactoryExample2.Execute();
                //    break;

                case '3':
                    ExecucaoAbstractFactoryExample3.Execute();
                    break;
            }
        }

    }
}
