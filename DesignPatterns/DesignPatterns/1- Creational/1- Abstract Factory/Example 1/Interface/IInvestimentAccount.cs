using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Example_1.Interface
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IInvestimentAccount
    {
        double GetInvestimentforMonth(int id);
        IInvestimentAccount GetById(int id);
        IList<IInvestimentAccount> ListAll();
    }
}
