using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface
{
    /// <summary>
    /// Abstract Factory it's same IBaseGenericRepository for all SavingsAccount
    /// </summary>
    public interface IAccountFactory
    {
        void Deposit(Account account, double value);
        void Transfer(double value, Account destinationAccount);

        string GetService();
    }
}
