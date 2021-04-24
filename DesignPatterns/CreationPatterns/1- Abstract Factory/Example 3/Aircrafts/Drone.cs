using System;
namespace CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Turn on!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Check camera, propeller Check propeller ok!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Starting the takeoff.");
        }
    }
}
