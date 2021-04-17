using System;
namespace CreationPatterns._1__Abstract_Factory.Example_3.Landvehicles
{
    class Car : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("We pick up the passengers and we are at the point");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Starting the path");
        }
    }
}
