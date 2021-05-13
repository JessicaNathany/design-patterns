using StructuralPatterns._2__Adapter.Interface;
using System;

namespace StructuralPatterns._2__Adapter
{
    public class MercadoPagoAdapter : IMercadoPagoPayment
    {
        private MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
            Console.WriteLine("Making the MercadoPago Adaptation to Paypal methods");
        }
        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void BlocksPayment()
        {
            _mercadoPago.BlocksPayment();
        }

        public void ReceivePayment()
        {
            _mercadoPago.ReceivePayment();
        }

        public void SendPayment()
        {
            _mercadoPago.SendPayment();
        }

        public void ValidateBank()
        {
            _mercadoPago.ValidateBank();
        }
    }
}
