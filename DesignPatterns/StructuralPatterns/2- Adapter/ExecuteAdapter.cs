using StructuralPatterns._2__Adapter.Interface;
using System;

namespace StructuralPatterns._2__Adapter
{
    public class ExecuteAdapter
    {
        public void Payment()
        {
            //Paypal payment = new Paypal();
            IPaypalPayment payment = new PayonnerAdapter(new Payonner());
            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
