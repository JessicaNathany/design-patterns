using StructuralPatterns._1__Bridge.Plataforms.Interface;
using System;

namespace StructuralPatterns._1__Bridge.Plataforms
{
    public class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmission started");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Authorized application");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configuring RMTP server");
        }
    }
}
