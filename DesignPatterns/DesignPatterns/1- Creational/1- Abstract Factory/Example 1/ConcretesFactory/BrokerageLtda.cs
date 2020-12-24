using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System;
using System.Collections.Generic;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.ConcretesFactory
{
    /// <summary>
    /// Concrete Factory
    /// This is class about Investiment Broker
    /// </summary>
    public class BrokerageLtda : IInvestimentAccountFactory
    {
        public double GetInvestimentforMonth(int id)
        {
            throw new NotImplementedException();
        }

        public void Invest(InvestimentAccount typeInvestiment, double value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvestimentAccount> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
