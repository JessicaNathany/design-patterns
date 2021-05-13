using StructuralPatterns._2__Adapter.Example_2.Interface;
using System;

namespace StructuralPatterns._2__Adapter.Example_2
{
    public class MagazineLuiza : IMagazineLuizaSupplier
    {
        public void SendProduct()
        {
            Console.WriteLine("Send the product");
        }
        public void ValidateProductPrice()
        {
            Console.WriteLine("Validating product");
        }
        public void SendProductPrice()
        {
            Console.WriteLine("Send the product price");
        }

        public void UpdateStock()
        {
            Console.WriteLine("Validating stock");
        }
    }
}
