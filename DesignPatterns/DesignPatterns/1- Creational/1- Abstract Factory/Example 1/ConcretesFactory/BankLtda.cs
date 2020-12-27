using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.ConcretesFactory
{
    /// <summary>
    /// Concrete Factory
    /// This is class about Bank current or Savings 
    /// </summary>
    public class BankLtda : IAccountFactory
    {
        public void Deposit(Account account, double value)
        {
            throw new NotImplementedException();
        }

        public string GetService()
        {
            throw new NotImplementedException();
        }

        public void Transfer(int destinationAgency, int destinationAccount, double value)
        {
            throw new NotImplementedException();
        }
    }
}
