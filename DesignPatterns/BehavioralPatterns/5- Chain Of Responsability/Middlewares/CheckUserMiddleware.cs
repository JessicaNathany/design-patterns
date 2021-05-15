using BehavioralPatterns._5__Chain_Of_Responsability.Servers;
using System;

namespace BehavioralPatterns._5__Chain_Of_Responsability.Middlewares
{
    public class CheckUserMiddleware : Middleware
    {
        private Server server;
        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if(!server.HasEmail(email))
            {
                Console.WriteLine("Invalid email!");
                return false;
            }

            if(!server.IsValidPassword(email, password))
            {
                Console.WriteLine("Invalid email or password");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
