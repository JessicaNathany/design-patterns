using StructuralPatterns._1__Bridge.Plataforms.Interface;
using System;

namespace StructuralPatterns._1__Bridge.Plataforms
{
    public class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmission started");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Authorized application");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configuring RMTP server");
        }
    }
}
