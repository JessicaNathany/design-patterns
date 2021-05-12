namespace StructuralPatterns._2__Adapter.Interface
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();

        void SendPayment();
        void ValidateBank();
        void ReceivePayment();
        void BlocksPayment();
    }
}
