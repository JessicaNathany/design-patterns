using System;
namespace CreationPatterns._1__Abstract_Factory.Example_3.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("check  the winds, 25km winds ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passengers on board. flight authorized");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Starting the takeoff.");
        }
    }
}
