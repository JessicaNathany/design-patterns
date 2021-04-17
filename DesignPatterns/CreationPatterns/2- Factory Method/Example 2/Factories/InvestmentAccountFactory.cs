using CreationPatterns._2__Factory_Method.Example_2.Banks;
using CreationPatterns._2__Factory_Method.Example_2.Interface;

namespace CreationPatterns._2__Factory_Method.Example_2.Factories
{
    class InvestmentAccountFactory : BankFactory
    {
        protected override IBanks CreateAccount()
        {
            return new InvestmentAccounts();
        }
    }
}
