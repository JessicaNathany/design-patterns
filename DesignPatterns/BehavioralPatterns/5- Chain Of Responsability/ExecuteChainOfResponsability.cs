using BehavioralPatterns._5__Chain_Of_Responsability.Middlewares;
using BehavioralPatterns._5__Chain_Of_Responsability.Servers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns._5__Chain_Of_Responsability
{
    public class ExecuteChainOfResponsability
    {
        private static Server server;
        public void TestMiddleware()
        {
            Init();
            Boolean done = false;

            do
            {
                Console.WriteLine("Write your email ");
                string email = Console.ReadLine();

                Console.WriteLine("Write your password ");
                string password = Console.ReadLine();

                done = server.Login(email, password);

            } while (!done);

            Console.ReadLine();
        }

        private void Init()
        {
            server = new Server();
            server.RegisterUser("master@jncoder.com.br", "admin@12!$");
            server.RegisterUser("user@jncoder.com.br", "user#90L");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            server.SetMiddleware(middleware);
        }
    }
}
