namespace StructuralPatterns._2__Adapter.Interface
{
    public interface IPaypalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
