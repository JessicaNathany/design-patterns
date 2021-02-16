using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1
{
    /// <summary>
    /// Product A2
    /// </summary>
    public class SavingsAccount : IAccountFactory
    {
        public void Deposit(Account account, double value)
        {
            throw new NotImplementedException();
        }

        public string GetService()
        {
            return "Savings Account - Service";
        }

        public void Transfer(double value, Account destinyAccount)
        {
            throw new NotImplementedException();
        }
    }
}
