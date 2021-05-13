
namespace StructuralPatterns._2__Adapter.Interface
{
    public interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
