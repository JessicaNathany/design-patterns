using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1
{
    /// <summary>
    /// Product A1
    /// </summary>
    public class PIX : IAccountFactory
    {
        public void Deposit(InvestimentAccount typeAccount, double value)
        {
            throw new NotImplementedException();
        }

        public void Deposit(Account account, double value)
        {
            throw new NotImplementedException(); 
        }

        public string GetService()
        {
            return "PIX - Service";
        }

        public void Transfer(double value, Account destinationAccount)
        {
            throw new NotImplementedException();
        }
    }
}
