using StructuralPatterns._2__Adapter.Interface;
using System;

namespace StructuralPatterns._2__Adapter
{
    public class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void BlocksPayment()
        {
            Console.WriteLine("Payment blocked to be analyzed");
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

        public void ValidateBank()
        {
            Console.WriteLine("Validating Bank");
        }
    }
}
