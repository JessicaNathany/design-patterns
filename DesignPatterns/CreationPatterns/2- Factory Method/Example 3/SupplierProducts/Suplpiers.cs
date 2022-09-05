using System;

namespace CreationPatterns._2__Factory_Method.Example_3.SupplierProducts
{
    public class Suplpiers : ISupplier
    {
        public void GetSupplier()
        {
            Console.WriteLine(" \n The Supplier is: \n Amazon,  \n Alibaba,  \n Shopee \n AliExpress \n ");
        }

        public void UpdateSupplierProductPrice()
        {
            GetSupplier();
            Console.WriteLine("Supplier update was successful!");
        }
    }
}
