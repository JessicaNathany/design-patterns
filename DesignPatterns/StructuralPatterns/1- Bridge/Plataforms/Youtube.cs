using StructuralPatterns._1__Bridge.Plataforms.Interface;
using System;

namespace StructuralPatterns._1__Bridge.Plataforms
{
    public class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmission started");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Authorized application");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configuring RMTP server");
        }
    }
}
