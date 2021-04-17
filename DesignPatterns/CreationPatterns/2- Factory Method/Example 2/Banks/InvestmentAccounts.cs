using CreationPatterns._2__Factory_Method.Example_2.Interface;
using System;

namespace CreationPatterns._2__Factory_Method.Example_2.Banks
{
    public class InvestmentAccounts : IBanks
    {
        public void GetBalance()
        {
            Console.WriteLine("The total value of your assets is: 10,500U$");
        }

        public void Transfer()
        {
            GetBalance();
            Console.WriteLine("Transfer was successful");
        }
    }
}
