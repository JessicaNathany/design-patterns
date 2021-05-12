using StructuralPatterns._2__Adapter.Interface;
using System;

namespace StructuralPatterns._2__Adapter
{
    public class Payonner : IPayonnerPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Receiving payment with Payonner");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Sending payment with Payonner");
        }
    }
}
