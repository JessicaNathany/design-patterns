using StructuralPatterns._2__Adapter.Interface;
using System;

namespace StructuralPatterns._2__Adapter
{
    public class ExecuteAdapter
    {
        public void Payment()
        {
            //Paypal payment = new Paypal();
            //payment.PayPalPayment();
            //payment.PayPalReceive();

            //IPaypalPayment payment = new PayonnerAdapter(new Payonner());
            //payment.PayPalPayment();
            //payment.PayPalReceive();

            IMercadoPagoPayment payment = new MercadoPagoAdapter(new MercadoPago());
            payment.BlocksPayment();
            payment.SendPayment();
            payment.ValidateBank();

            Console.ReadLine();
        }
    }
}
