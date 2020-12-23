using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using System;
using System.Collections.Generic;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.ConcretesFactory
{
    /// <summary>
    /// Concrete Factory
    /// This is class about Investiment Broker
    /// </summary>
    public class Easyinvest : IInvestimentAccount
    {
        public IInvestimentAccount GetById(int id)
        {
            throw new NotImplementedException();
        }

        public double GetInvestimentforMonth(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IInvestimentAccount> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
