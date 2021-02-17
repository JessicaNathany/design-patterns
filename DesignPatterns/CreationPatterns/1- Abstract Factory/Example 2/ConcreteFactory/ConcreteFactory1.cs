using CreationPatterns._1__Abstract_Factory.Example_2.Interface;
using CreationPatterns._1__Abstract_Factory.Example_2.Product;

namespace CreationPatterns._1__Abstract_Factory.Example_2.ConcreteFactory
{
   
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
