using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IInvestimentAccountFactory
    {
        double GetInvestimentforMonth(int id);
        void Invest(InvestimentAccount typeInvestiment, double value);
        string GetInvestiment();
    }
}
