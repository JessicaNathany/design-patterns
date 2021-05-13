namespace StructuralPatterns._2__Adapter.Example_2.Interface
{
    public interface IAmazonSupplier
    {
        void SendProduct();
        void ValidateProductPrice();
        void SendProductPrice();
        void UpdateStock();
        void UpdateWarehouse();
        void UpdateStore();
    }
}
