using StructuralPatterns._1__Bridge.Plataforms.Interface;
using System;

namespace StructuralPatterns._1__Bridge.Transmissions
{
    public class Live : ITransmission
    {
        protected IPlatform _platform;
        public Live(IPlatform plataform)
        {
            _platform = plataform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Starting the transmission in {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("-- On AIR ---");
        }
    }
}
