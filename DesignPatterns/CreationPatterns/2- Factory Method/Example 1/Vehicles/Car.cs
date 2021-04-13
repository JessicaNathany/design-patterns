using CreationPatterns._2__Factory_Method.Example_1.Interface;
using System;

namespace CreationPatterns._2__Factory_Method.Example_1
{
    public class Car : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Get passangers");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Start the route");
        }
    }
}
