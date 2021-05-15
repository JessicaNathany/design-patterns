using System;

namespace BehavioralPatterns._5__Chain_Of_Responsability.Middlewares
{
    public class CheckPermissionMiddleware : Middleware
    {
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

    }
}
