using CreationPatterns._2__Factory_Method.Example_1.Interface;
using System;

namespace CreationPatterns._2__Factory_Method.Example_1.Vehicles
{
    public class Motorcycle : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Get food");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Start delivery");
        }
    }
}
