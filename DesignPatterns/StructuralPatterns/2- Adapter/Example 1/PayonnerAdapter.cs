using System;

namespace StructuralPatterns._2__Adapter.Interface
{
    class PayonnerAdapter : IPaypalPayment
    {
        private Payonner _payonner;
        public PayonnerAdapter(Payonner payonner)
        {
           _payonner = payonner;
            Console.WriteLine("Making the Payonner Adaptation to Paypal methods");
        }
        public Token AuthToken()
        {
            return _payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            _payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            _payonner.ReceivePayment();
        }
    }
}
