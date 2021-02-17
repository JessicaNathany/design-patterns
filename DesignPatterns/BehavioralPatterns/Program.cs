using System;

namespace BehavioralPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Behavioral Patterns select an option ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Example one");
            Console.WriteLine("2 - Example two");
            Console.WriteLine("3 - Example three");
            Console.WriteLine("------------------------");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                //case '1':
                //    new ExecuteAbstractFactory().ExampleOne();
                //    break;

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
