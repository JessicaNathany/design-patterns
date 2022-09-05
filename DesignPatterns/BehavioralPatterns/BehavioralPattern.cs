using BehavioralPatterns._5__Chain_Of_Responsability;
using System;

namespace BehavioralPatterns
{
    public class BehavioralPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Behavioral Patterns select an option ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Chain Of Responsability Middleware");
            Console.WriteLine();
            Console.WriteLine("2 - Chain Of Responsability Example two");
            Console.WriteLine();
            Console.WriteLine("3 - Chain Of Responsability Example three");
            Console.WriteLine("------------------------");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    new ExecuteChainOfResponsability().TestMiddleware();
                    break;

                    //case '2':
                    //    new ExecuteAbstractFactory().ExampleTwo();
                    //    break;

                    //case '3':
                    //    new ExecuteAbstractFactory().ExampleThree();
                    //    break;
            }
        }
    }
}
