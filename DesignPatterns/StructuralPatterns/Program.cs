using StructuralPatterns._2__Adapter;
using StructuralPatterns._2__Adapter.Example_2;
using System;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Structural Patterns select an option ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Adapter Payment");
            Console.WriteLine();
            Console.WriteLine("2 - Example Ecommerce");
            Console.WriteLine();
            Console.WriteLine("3 - Example three");
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

                    //case '3':
                    //    new Execute().ExampleThree();
                    //    break;
            }
        }
    }
}
