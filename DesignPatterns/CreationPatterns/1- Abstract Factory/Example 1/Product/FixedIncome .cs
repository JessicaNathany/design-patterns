using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1
{
    /// <summary>
    /// Product B1 
    /// </summary>
    public class FixedIncome : IInvestimentAccountFactory
    {
        public string GetInvestiment()
        {
            return "Fixed Income";
        }

        public double GetInvestimentforMonth(int id)
        {
            throw new NotImplementedException();
        }

        public void Invest(InvestimentAccount typeInvestiment, double value)
        {
            throw new NotImplementedException();
        }
    }
}
