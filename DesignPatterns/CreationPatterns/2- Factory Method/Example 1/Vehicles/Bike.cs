using CreationPatterns._2__Factory_Method.Example_1.Interface;
using System;

namespace CreationPatterns._2__Factory_Method.Example_1.Vehicles
{
    public class Bike : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Get package");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Start delivery");
        }
    }
}
