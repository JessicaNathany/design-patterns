using StructuralPatterns._2__Adapter.Example_2.Interface;
using System;

namespace StructuralPatterns._2__Adapter.Example_2
{
    public class AmazonAdapter : IAmazonSupplier
    {
        private Amazon _amazon;

        public AmazonAdapter(Amazon amazon)
        {
            _amazon = amazon;
            Console.WriteLine("Making the Amazon Adaptation to MagazineLuiza methods");
        }

        public void SendProduct()
        {
            _amazon.SendProduct();
        }
        public void ValidateProductPrice()
        {
            _amazon.ValidateProductPrice();
        }

        public void SendProductPrice()
        {
            _amazon.SendProductPrice();
        }

        public void UpdateStock()
        {
            _amazon.UpdateStock();
        }

        public void UpdateStore()
        {
            _amazon.UpdateStore();
        }

        public void UpdateWarehouse()
        {
            _amazon.UpdateWarehouse();
        }
    }
}
