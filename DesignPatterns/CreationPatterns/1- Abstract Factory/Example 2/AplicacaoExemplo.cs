using System;
namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_3
{
    /// <summary>
    /// Exemplo tirado do site https://www.dofactory.com/net/abstract-factory-design-pattern
    /// </summary>
    public class AplicacaoExemplo
    {
        //public static void Main()
        //{
        //    // Abstract factory #1

        //    AbstractFactory factory1 = new ConcreteFactory1();
        //    Cliente cliente1 = new Cliente(factory1);
        //    cliente1.Run();

        //    // Abstract factory #2

        //    AbstractFactory factory2 = new ConcreteFactory2();
        //    Cliente cliente2 = new Cliente(factory2);
        //    cliente2.Run();

        //    Console.ReadKey();
        //}
    }

    /// <summary>
    /// Classe abastrata 'AbstractFactory' 
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CriaProdutoA();
        public abstract AbstractProductB CriaProdutoB();
    }

    /// <summary>
    /// Classe 'ConcreteFactory1' 
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CriaProdutoA()
        {
            return new ProdutoA1();
        }
        public override AbstractProductB CriaProdutoB()
        {
            return new ProdutoB1();
        }
    }

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CriaProdutoA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CriaProdutoB()
        {
            return new ProductB2();
        }
    }

    /// <summary>
    /// Classe AbstractProductA
    /// </summary>

    abstract class AbstractProductA
    {
    }

    /// <summary>
    /// <summary>
    /// Classe AbstractProductB
    /// </summary>
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    /// <summary>
    ///  Classe ProdutoA1
    /// </summary>
    class ProdutoA1 : AbstractProductA
    {

    }

    /// <summary>
    ///  Classe ProdutoB1
    /// </summary>
    class ProdutoB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interage com " + a.GetType().Name);
        }
    }

    /// <summary>
    /// Classe ProdutoA2
    /// </summary>
    class ProductA2 : AbstractProductA
    {
    }

    /// <summary>
    ///  Classe ProdutoB2
    /// </summary>
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interage com " + a.GetType().Name);
        }
    }

    /// <summary>
    /// A classe Cliente interage com os produtos
    /// </summary>
    class Cliente
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Constructor

        public Cliente(AbstractFactory factory)
        {
            _abstractProductB = factory.CriaProdutoB();
            _abstractProductA = factory.CriaProdutoA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
