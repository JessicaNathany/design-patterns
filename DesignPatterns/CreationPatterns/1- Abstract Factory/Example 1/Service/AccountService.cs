using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1
{
    public class AccountService
    {
        IAccountFactory _accountFactory;
        public AccountService(IAccountFactory accountFactory)
        {
            _accountFactory = accountFactory;
        }

        private void Deposit(double value)
        {
            var account = new Account();

            _accountFactory.Deposit(account, value);
        }

        private void Transfer(double value, Account destinyAccount)
        {
            _accountFactory.Transfer(value, destinyAccount);
        }
    }
}
