using DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface;
using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1
{
    public class AccountService
    {
        IAccountFactory _accountFactory;

        public AccountService(IAccountFactory accountFactory)
        {
            _accountFactory = accountFactory;
        }

        public void Deposit(double value)
        {
            var account = new Account();

            _accountFactory.Deposit(account, value);
        }

        public void Transer(int agency, int destinationAccount, double value)
        {
            _accountFactory.Transfer(agency, destinationAccount, value);
        }
    }
}
