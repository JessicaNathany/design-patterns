using CreationPatterns._2__Factory_Method.Example_3.SupplierProducts;

namespace CreationPatterns._2__Factory_Method.Example_3.Factories
{
    class SupplierFactory : SupplierProductsFactory
    {
        protected override ISupplier GetProductsPriceUpdate()
        {
            return new Suplpiers();
        }
    }
}
