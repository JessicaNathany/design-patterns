using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1
{
    public class InvestimentService
    {
        IInvestimentAccountFactory _investimentAccountFactory;

        public InvestimentService(IInvestimentAccountFactory investimentAccountFactory)
        {
            _investimentAccountFactory = investimentAccountFactory;
        }

        public void Invest(InvestimentAccount investimentAccount, double value)
        {
            _investimentAccountFactory.Invest(investimentAccount, value);
        }
    }
}
