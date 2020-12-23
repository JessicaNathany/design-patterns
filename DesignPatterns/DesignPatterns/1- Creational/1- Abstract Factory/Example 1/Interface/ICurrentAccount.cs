using DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1;
using System.Collections.Generic;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface ICurrentAccount
    {
        double GetBalance(int id);

        CurrentAccount GetById(int id);

        IList<CurrentAccount> ListAll();
    }
}
