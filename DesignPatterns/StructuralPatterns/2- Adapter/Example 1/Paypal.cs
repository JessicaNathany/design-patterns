using StructuralPatterns._2__Adapter.Interface;
using System;

namespace StructuralPatterns._2__Adapter
{
    class Paypal : IPaypalPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Send payment with Paypal");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Receiving payment with Paypal");
        }
    }
}
