using StructuralPatterns._1__Bridge;
using StructuralPatterns._2__Adapter;
using StructuralPatterns._2__Adapter.Example_2;
using System;

namespace StructuralPatterns
{
    class StructuralPatterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Structural Patterns select an option ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Adapter Example Payment");
            Console.WriteLine();
            Console.WriteLine("2 - Adapter Example Ecommerce");
            Console.WriteLine();
            Console.WriteLine("3 - Bridge Platform");
            Console.WriteLine();
            Console.WriteLine("------------------------");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    new ExecuteAdapter().Payment();
                    break;

                case '2':
                    new ExecuteAdapterEcommerce().Ecommerce();
                    break;

                case '3':
                    new ExecuteBridge().TestBridgePlatform();
                    break;
            }
        }
    }
}
