using System;

namespace CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("check  the winds, southeast ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passengers ok, turning on the propellers!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Starting the takeoff!");

        }
    }
}
