using CreationPatterns._2__Factory_Method.Example_3.SupplierProducts;

namespace CreationPatterns._2__Factory_Method.Example_3.Factories
{
    abstract class SupplierProductsFactory
    {
        public void GetProductsSupplier()
        {
            ISupplier supplier = GetProductsPriceUpdate();
            supplier.UpdateSupplierProductPrice();
        }

        protected abstract ISupplier GetProductsPriceUpdate();
    }
}
