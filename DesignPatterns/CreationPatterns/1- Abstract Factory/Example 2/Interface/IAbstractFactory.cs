namespace CreationPatterns._1__Abstract_Factory.Example_2.Interface
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
