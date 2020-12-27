using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IAccountFactory
    {
        void Deposit(Account account, double value);
        void Transfer(int destinationAgency, int destinationAccount, double value);

        string GetService();
    }
}
