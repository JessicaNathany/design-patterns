using StructuralPatterns._2__Adapter.Example_2.Interface;

namespace StructuralPatterns._2__Adapter.Example_2
{
    public class ExecuteAdapterEcommerce
    {
        public void Ecommerce()
        {
            //MagazineLuiza magazineLuiza = new MagazineLuiza();
            //magazineLuiza.SendProduct();
            //magazineLuiza.ValidateProductPrice();
            //magazineLuiza.SendProductPrice();
            //magazineLuiza.UpdateStock();

            IAmazonSupplier amazon = new AmazonAdapter(new Amazon());
            amazon.SendProduct();
            amazon.ValidateProductPrice();
            amazon.SendProductPrice();
            amazon.UpdateStock();
            amazon.UpdateStore();
            amazon.UpdateWarehouse();
        }
    }
}
