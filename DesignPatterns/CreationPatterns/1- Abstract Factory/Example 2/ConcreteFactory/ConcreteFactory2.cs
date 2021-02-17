using CreationPatterns._1__Abstract_Factory.Example_2.Interface;
using CreationPatterns._1__Abstract_Factory.Example_2.Product;
using System;

namespace CreationPatterns._1__Abstract_Factory.Example_2.ConcreteFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            throw new NotImplementedException();
        }
    }
}
