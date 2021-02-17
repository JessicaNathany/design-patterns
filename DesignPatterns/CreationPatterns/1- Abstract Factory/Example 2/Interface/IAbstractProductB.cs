namespace CreationPatterns._1__Abstract_Factory.Example_2.Interface
{
    /// <summary>
    /// Here's the the base interface of another product. All products can
    /// interact with each other, but proper interaction is possible only between
    /// products of the same concrete variant.
    /// </summary>
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
