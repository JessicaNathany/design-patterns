using System;
namespace CreationPatterns._1__Abstract_Factory.Example_3.Landvehicles
{
    public class Scotter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("We pick up the package.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Starting the deilvery.");
        }
    }
}
