using BehavioralPatterns._5__Chain_Of_Responsability.Middlewares;
using System;
using System.Collections.Generic;

namespace BehavioralPatterns._5__Chain_Of_Responsability.Servers
{
    public class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public Boolean Login(string email, string password)
        {
            if(middleware.Check(email, password)) 
            {
                Console.WriteLine("Authorized success!");
                Console.WriteLine("Wellcome!");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password)
        {
            var value = "";
            users.TryGetValue(email, out value);
            return password == value;
        }
    }
}
