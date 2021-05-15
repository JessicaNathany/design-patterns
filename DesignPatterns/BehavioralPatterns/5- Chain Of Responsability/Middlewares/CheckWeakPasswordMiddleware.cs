using BehavioralPatterns._5__Chain_Of_Responsability.Servers;
using System;

namespace BehavioralPatterns._5__Chain_Of_Responsability.Middlewares
{
    public class CheckWeakPasswordMiddleware : Middleware
    {
        private Server server;
        public CheckWeakPasswordMiddleware(Server server)
        {
            this.server = server;
        }
        public override bool Check(string email, string password)
        {
            if (email.Equals("administrador@server1.com.br"))
            {
                Console.WriteLine("Wellcome to administrator!");
                return true;
            }

            Console.WriteLine("Wellcome!");
            return CheckNext(email, password);
        }

        // to be continued...
    }
}
